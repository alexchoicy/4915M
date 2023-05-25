using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Server.Model.Entity;

namespace Server.Helper
{
    public class JwtToken
    {
        protected readonly IConfiguration _configuration;

        public JwtToken(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Creater(string staffId, string PositionName)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, staffId),
                new(ClaimTypes.Role, PositionName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:KEY"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var jwt = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(5),
                signingCredentials: creds
            );
            var token = new JwtSecurityTokenHandler().WriteToken(jwt);
            return token;
        }
    }
}
