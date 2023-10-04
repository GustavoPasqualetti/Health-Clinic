using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;
using HealthClinic_cd.Repositores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HealthClinic_cd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoDeUsuarioController : ControllerBase
    {
        private readonly ITipoDeUsuarioRepository _tipoDeUsuarioRepository;

        public TipoDeUsuarioController()
        {
            _tipoDeUsuarioRepository = new TipoDeUsuarioRepository();
        }

        [HttpPost]
       // [Authorize(Roles = "administrador")]
        public IActionResult Post(TipoDeUsuario tipoDeUsuario)
        {
            try
            {
                _tipoDeUsuarioRepository.Cadastrar(tipoDeUsuario);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
       // [Authorize(Roles = "administrador")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tipoDeUsuarioRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
