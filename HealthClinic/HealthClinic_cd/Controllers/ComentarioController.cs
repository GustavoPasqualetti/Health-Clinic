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

        /// <summary>
        /// Endpoint que recebe o metodo de cadastrar um comentario
        /// </summary>
        /// <param name="comentario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Endpoint que recebe o metodo de listar um comentario pelo id da consulta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Endpoint que recebe o metodo de atualizar um comentario
        /// </summary>
        /// <param name="comentario"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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
