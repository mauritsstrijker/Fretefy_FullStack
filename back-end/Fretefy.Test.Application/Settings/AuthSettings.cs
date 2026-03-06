namespace Fretefy.Test.Application.Settings
{
    public class AuthSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccessTokenMinutes { get; set; } = 15;
        public int RefreshTokenDays { get; set; } = 7;
    }
}
