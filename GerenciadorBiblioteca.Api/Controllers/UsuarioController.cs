using GerenciadorBiblioteca.Api.Interface;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet]
        [Route("Consultar/{id}")]
        public IActionResult Consultar(int id)
        {
            var retorno = _usuarioService.Consultar(id);
            return Ok(new { id });
        }

        [HttpPost]
        [Route("Cadastrar/")]
        public IActionResult Cadastrar(CadastrarUsuarioRequest request)
        { 
            var retorno = _usuarioService.Cadastrar(request);
            return BadRequest();
        }
    }
}
