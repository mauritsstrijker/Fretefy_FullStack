using System.Threading.Tasks;

namespace Fretefy.Test.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> LoginAsync(string username, string password);
        Task<AuthResult> RefreshAsync(string refreshToken);
        Task RevokeAsync(string refreshToken);
        Task RevokeAllAsync(string username);
    }

    public class AuthResult
    {
        public bool Success { get; set; }
        public string Username { get; set; }
        public string RefreshToken { get; set; }
        public string ErrorMessage { get; set; }

        public static AuthResult Ok(string username, string refreshToken)
            => new AuthResult { Success = true, Username = username, RefreshToken = refreshToken };

        public static AuthResult Fail(string message)
            => new AuthResult { Success = false, ErrorMessage = message };
    }
}
