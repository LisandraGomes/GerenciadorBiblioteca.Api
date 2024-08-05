using GerenciadorBiblioteca.Api.Interface;
using GerenciadorBiblioteca.Api.Response;
using WebApplication1.Request;

namespace WebApplication1.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public EmprestimoResponse Cadastrar(CadastrarEmprestimoRequest request)
        {
            return new EmprestimoResponse { };
        }
        public bool Devolver(int id)
        { 
            return false;
        }
        public IEnumerable<EmprestimoResponse> EmprestimoPorUsuario(int idUsuario)
        {
            return new List<EmprestimoResponse>{ };
        }
    }
}
