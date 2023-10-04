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
    public class ProntuarioController : ControllerBase
    {
        private readonly IProntuarioRepository _prontuarioRepository;

        public ProntuarioController()
        {
            _prontuarioRepository = new ProntuarioRepository();
        }

        [HttpPost]
      //  [Authorize(Roles = "Medico,administrador")]
        public IActionResult Post(Prontuario prontuario)
        {
            try
            {
                _prontuarioRepository.Cadastrar(prontuario);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
       // [Authorize(Roles = "Paciente,Medico,administrador")]
        public IActionResult BuscarPorIdConsulta(Guid id)
        {
            try
            {
                return Ok(_prontuarioRepository.BuscarPorIdConsulta(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
       // [Authorize(Roles = "Medico,administrador")]
        public IActionResult Put(Guid id, Prontuario prontuario)
        {
            try
            {
                _prontuarioRepository.Atualizar(id, prontuario);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
    
}
