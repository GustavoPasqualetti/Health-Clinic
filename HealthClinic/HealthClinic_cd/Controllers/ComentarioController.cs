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
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioRepository _comentarioRepository;

        public ComentarioController()
        {
            _comentarioRepository = new ComentarioRepository();
        }

        [HttpPost]
        //[Authorize(Roles = "Paciente,Medico,administrador")]
        public IActionResult Post(Comentario comentario)
        {
            try
            {
                _comentarioRepository.Cadastrar(comentario);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
       // [Authorize(Roles = "Medico,administrador")]
        public IActionResult BuscarPorIdConsulta(Guid id)
        {
            try
            {
                return Ok(_comentarioRepository.BuscarPorIdConsulta(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
       // [Authorize(Roles = "Paciente,Medico,administrador")]
        public IActionResult Put(Comentario comentario, Guid id)
        {
            try
            {
                _comentarioRepository.Atualizar (comentario, id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
