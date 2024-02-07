using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using HealthClinic_cd.Interfaces;
using HealthClinic_cd.Repositores;
using HealthClinic_cd.ViewModels;
using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        LoginController()
        {
            _usuarioRepository = new UsuarioRepository(); 
        }

        /// <summary>
        /// Endpoint que recebe o metodo de logar um usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(LoginViewModel usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmaileSenha(usuario.Email!, usuario.Senha!);

                if (usuarioBuscado == null)
                {
                    return StatusCode(401, "Email ou senha invalidos");
                }

                var claims = new[]
                {
                    new Claim (JwtRegisteredClaimNames.Email, usuarioBuscado.Email!),
                    new Claim (JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()!),
                    new Claim (ClaimTypes.Role, usuarioBuscado.TipoDeUsuario!.Titulo!)
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("HealthClinic-chave-autenticacao-webapi-dev"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "HealthClinic_cd",
                    audience: "HealthClinic_cd",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: creds
                    );

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
