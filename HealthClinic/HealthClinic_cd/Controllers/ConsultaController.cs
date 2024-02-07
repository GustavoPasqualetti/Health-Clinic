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
    public class ConsultaController : ControllerBase
    {
        private readonly IConsultaRepository _consultaRepository;

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        /// <summary>
        /// Endpoint que recebe o metodo de cadastrar uma consulta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        [HttpPost]
        //[Authorize(Roles = "administrador")]
        public IActionResult Post(Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastar(consulta);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de listar as consultas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Authorize(Roles = "Paciente,Medico,administrador")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_consultaRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de deletar uma consulta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        //[Authorize(Roles = "administrador")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _consultaRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de atualizar uma consulta pelo id
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        //[Authorize(Roles = "administrador")]
        public IActionResult Put(Consulta consulta, Guid id)
        {
            try
            {
                _consultaRepository.Atualizar(consulta, id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de listar uma consulta pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        //[Authorize(Roles = "Paciente,Medico,administrador")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_consultaRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de listar uma consulta do paciente
        /// </summary>
        /// <param name="IdPaciente"></param>
        /// <returns></returns>
        [HttpGet("IdPaciente")]
        //[Authorize(Roles = "Paciente,administrador")]
        public IActionResult BuscarIdPaciente(Guid IdPaciente)
        {
            try
            {
                return Ok(_consultaRepository.BucarIdPaciente(IdPaciente));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de listar uma consulta ddo medico
        /// </summary>
        /// <param name="IdMedico"></param>
        /// <returns></returns>
        [HttpGet("IdMedico")]
        //[Authorize(Roles = "Medico,administrador")]
        public IActionResult BuscarIdMedico(Guid IdMedico)
        {
            try
            {
                return Ok(_consultaRepository.BuscarIdMedico(IdMedico));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
