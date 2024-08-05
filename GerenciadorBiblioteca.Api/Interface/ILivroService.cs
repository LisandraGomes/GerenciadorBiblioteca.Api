using WebApplication1.Request;
using WebApplication1.Response;

namespace WebApplication1.Interface
{
    public interface ILivroService
    {
        bool Cadastrar(CadastrarLivroRequest request);
        ConsultaLivroResponse Consulta(int? id, string? isbn);
        IEnumerable<ConsultaLivroResponse> ConsultarLivros();
        bool Remover(int id);
    }
}
