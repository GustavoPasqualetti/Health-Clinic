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
    public class EspecialidadeController : ControllerBase
    {
        private readonly IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        /// <summary>
        /// Endpoint que recebe o metodo de cadastrar uma especialidade
        /// </summary>
        /// <param name="especialidade"></param>
        /// <returns></returns>
        [HttpPost]
       // [Authorize(Roles = "administrador")]
        public IActionResult Post(Especialidade especialidade)
        {
            try
            {
                _especialidadeRepository.Cadastrar(especialidade);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de listar as especialidades
        /// </summary>
        /// <returns></returns>
        [HttpGet]
       // [Authorize(Roles = "administrador")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_especialidadeRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de deletar uma especialidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
       // [Authorize(Roles = "administrador")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
