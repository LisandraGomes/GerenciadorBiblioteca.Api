using GerenciadorBiblioteca.Api.Response;
using WebApplication1.Request;

namespace GerenciadorBiblioteca.Api.Interface
{
    public interface IEmprestimoService
    {
        EmprestimoResponse Cadastrar(CadastrarEmprestimoRequest request);
        bool Devolver(int id);  
        IEnumerable<EmprestimoResponse> EmprestimoPorUsuario(int idUsuario);
    }
}
