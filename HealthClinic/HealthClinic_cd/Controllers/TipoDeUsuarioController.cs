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

        /// <summary>
        /// Endpoint que recebe o metodo de cadastrar um tipo de usuario
        /// </summary>
        /// <param name="tipoDeUsuario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Endpoint que recebe o metodo de deletar um tipo de usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
