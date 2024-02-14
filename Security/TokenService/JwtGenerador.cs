using Entities.Models;
using Microsoft.IdentityModel.Tokens;
using Security.Imp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Security.TokenService
{
    public class JwtGenerador : IJwtGenerador
    {
        public string CrearToken(Cliente usuario)
        {
            var claims = new List<Claim>{
                new Claim(JwtRegisteredClaimNames.NameId, usuario.UserName)
            };

           

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("egMp4mt54j!1wqrPKr447Bnua9Hl0u6ZAj1JpGoGLBZ$nR#ZYS"));
            var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescripcion = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(30),
                SigningCredentials = credenciales
            };

            var tokenManejador = new JwtSecurityTokenHandler();
            var token = tokenManejador.CreateToken(tokenDescripcion);

            return tokenManejador.WriteToken(token);
        }
    }
}
