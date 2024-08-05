using GerenciadorBiblioteca.Api.Response;
using WebApplication1.Request;

namespace GerenciadorBiblioteca.Api.Interface
{
    public interface IUsuarioService
    {
        bool Cadastrar(CadastrarUsuarioRequest request);
        UsuarioResponse Consultar(int id);
    }
}
