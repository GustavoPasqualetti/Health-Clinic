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

        /// <summary>
        /// Endpoint que recebe o metodo de cadastrar um prontuario
        /// </summary>
        /// <param name="prontuario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Endpoint que recebe o metodo de buscar um prontuario pelo id da consulta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Endpoint que recebe o metodo de atualizar um prontuario pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prontuario"></param>
        /// <returns></returns>
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
