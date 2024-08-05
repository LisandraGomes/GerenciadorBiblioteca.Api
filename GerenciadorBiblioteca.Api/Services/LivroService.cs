using WebApplication1.Interface;
using WebApplication1.Request;
using WebApplication1.Response;

namespace WebApplication1.Services
{
    public class LivroService : ILivroService
    {
        public bool Cadastrar(CadastrarLivroRequest request)
        {
            return false;
        }
        public ConsultaLivroResponse Consulta(int? id, string? isbn)
        {
            ValidarConsulta(id, isbn);

            return new ConsultaLivroResponse { };
        }
        public IEnumerable<ConsultaLivroResponse> ConsultarLivros()
        {
            return new List<ConsultaLivroResponse> { };
        }
        public bool Remover(int id) 
        { 
            return false; 
        }
        private bool ValidarConsulta(int? id, string? isbn)
        {
            if (id == 0 && isbn == null)
                return false;
            
            return true; 
        }    

    }
}
