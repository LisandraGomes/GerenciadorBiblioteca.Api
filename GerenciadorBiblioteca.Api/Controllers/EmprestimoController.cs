using Microsoft.AspNetCore.Mvc;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class EmprestimoController : ControllerBase
    {
        [HttpPost]
        [Route("Cadastrar/")]
        public IActionResult Cadastrar(CadastrarEmprestimoRequest request) 
        {
            return Ok(request);
        }
        [HttpGet]
        [Route("ConsultarPorUsuario")]
        public IActionResult ConsultarEmprestimosPorUsuarios(int idUsuario)
        {
            return BadRequest();
        }
        [HttpPost]
        [Route("Devolver/{id}")]
        public IActionResult Devolver(int id)
        {
            return BadRequest();
        }
    }
}
