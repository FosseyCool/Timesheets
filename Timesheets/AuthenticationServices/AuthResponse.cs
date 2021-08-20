namespace Timesheets.AuthenticationServices
{
    public class AuthResponse
    {
        public string Password { get; set; }
        public RefreshToken LatesRefreshToken { get; set; }
    }
}