using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TicketMicroservice.Shared.Config;

namespace TicketMicroservice.Web.Auth
{
    public interface IJwtIssuerOptions
    {
        String Issuer { get; }
        String Audience { get; }
        TimeSpan ValidFor { get; }
        DateTime NotBefore { get; }
        DateTime IssuedAt { get; }
        DateTime Expires { get; }
        Task<String> JtiGenerator();

        SigningCredentials SigningCredentials { get; }
    }
    public class JwtIssuerFactory : IJwtIssuerOptions
    {
        public String Issuer { get; private set; }
        public String Audience { get; private set; }
        public TimeSpan ValidFor { get; private set; }
        public DateTime NotBefore { get; private set; }
        public DateTime IssuedAt { get; private set; }
        public DateTime Expires { get; private set; }

        public SigningCredentials SigningCredentials { get; private set; }

        public JwtIssuerFactory(IOptions<JwtTokenValidationSettings> options)
        {
            Issuer = options.Value.ValidIssuer;
            Audience = options.Value.ValidAudience;

            IssuedAt = DateTime.UtcNow;
            NotBefore = IssuedAt;

            ValidFor = TimeSpan.FromMinutes(options.Value.Duration);
            Expires = IssuedAt.Add(ValidFor);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.SecretKey));
            SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        }

        public async Task<String> JtiGenerator()
        {
            return await Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}