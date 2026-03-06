using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Settings;
using Fretefy.Test.WebApi.Requests;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly AuthSettings _authSettings;
        private const string RefreshTokenCookieName = "Fretefy.RefreshToken";

        public AuthController(IAuthService authService, IOptions<AuthSettings> authSettings)
        {
            _authService = authService;
            _authSettings = authSettings.Value;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _authService.LoginAsync(request.Username, request.Password);

            if (!result.Success)
                return Unauthorized(new { message = result.ErrorMessage });

            await SignInWithCookieAsync(result.Username);
            SetRefreshTokenCookie(result.RefreshToken);

            return Ok(new { message = "Login realizado com sucesso." });
        }

        [HttpPost("refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh()
        {
            var refreshToken = Request.Cookies[RefreshTokenCookieName];
            var result = await _authService.RefreshAsync(refreshToken);

            if (!result.Success)
            {
                DeleteRefreshTokenCookie();
                return Unauthorized(new { message = result.ErrorMessage });
            }

            await SignInWithCookieAsync(result.Username);
            SetRefreshTokenCookie(result.RefreshToken);

            return Ok(new { message = "Token renovado com sucesso." });
        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            var refreshToken = Request.Cookies[RefreshTokenCookieName];
            await _authService.RevokeAsync(refreshToken);

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            DeleteRefreshTokenCookie();

            return Ok(new { message = "Logout realizado com sucesso." });
        }

        [HttpPost("revoke-all")]
        [Authorize]
        public async Task<IActionResult> RevokeAll()
        {
            await _authService.RevokeAllAsync(User.Identity.Name);

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            DeleteRefreshTokenCookie();

            return Ok(new { message = "Todas as sessões foram revogadas." });
        }

        [HttpGet("me")]
        [Authorize]
        public IActionResult Me()
        {
            return Ok(new { username = User.Identity.Name });
        }

        private async Task SignInWithCookieAsync(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var accessMinutes = _authSettings.AccessTokenMinutes;

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal,
                new AuthenticationProperties
                {
                    IsPersistent = false,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(accessMinutes)
                });
        }

        private void SetRefreshTokenCookie(string refreshToken)
        {
            var refreshDays = _authSettings.RefreshTokenDays;

            Response.Cookies.Append(RefreshTokenCookieName, refreshToken, new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict,
                // apenas para desenvolvimento
                Secure = Request.IsHttps,
                Expires = DateTimeOffset.UtcNow.AddDays(refreshDays),
                Path = "/api/auth"
            });
        }

        private void DeleteRefreshTokenCookie()
        {
            Response.Cookies.Delete(RefreshTokenCookieName, new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict,
                // apenas para desenvolvimento
                Secure = Request.IsHttps,
                Path = "/api/auth"
            });
        }
    }
}
