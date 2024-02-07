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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Endpoint que recebe o metodo de cadastrar um usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
     //   [Authorize(Roles = "administrador")]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de buscar um usuario pelo email e senha
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        [HttpGet]
      //  [Authorize(Roles = "administrador")]
        public IActionResult BuscarPorEmaileSenha(string email, string senha)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorEmaileSenha(email, senha));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de deletar um usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
      //  [Authorize(Roles = "administrador")]
        public IActionResult Delete(Guid id) 
        {
            try
            {
                _usuarioRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de listar um usuario pelo seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
     //   [Authorize(Roles = "administrador")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que recebe o metodo de atualizar um usuario pelo id
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
      //  [Authorize(Roles = "administrador")]
        public IActionResult Put(Usuario usuario, Guid id)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario, id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
