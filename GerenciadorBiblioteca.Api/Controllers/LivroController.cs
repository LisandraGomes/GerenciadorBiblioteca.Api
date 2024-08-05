using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;
        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }
        [HttpPost]
        [Route("/Cadastrar")]
        public IActionResult Cadastrar(CadastrarLivroRequest request)
        {
            return Ok(request);
        }
        [HttpGet]
        [Route("/Consultar/livro={id}/isbn={isbn}")]
        public IActionResult Consultar(int? id, string? isbn)
        {
            var consulta = _livroService.Consulta(id, isbn);
            if (consulta == null)
                return NotFound("Não foi passado informações validas.");

            return Ok(consulta);
        }
        [HttpGet]
        [Route("ConsultarLivros/")]
        public IActionResult ConsultarLivros()
        {
            return Ok();
        }
        [HttpDelete]
        [Route("Remover/{id}")]
        public IActionResult Remover(int id)
        {
            return Ok();
        }

    }
}
