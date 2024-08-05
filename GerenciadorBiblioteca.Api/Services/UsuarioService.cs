using GerenciadorBiblioteca.Api.Interface;
using GerenciadorBiblioteca.Api.Response;
using WebApplication1.Request;

namespace WebApplication1.Services
{
    public class UsuarioService : IUsuarioService
    {
        public UsuarioResponse Consultar(int id)
        {
            return new UsuarioResponse { };
        }
        public bool Cadastrar(CadastrarUsuarioRequest request) 
        { 
            return false;
        }
    }
}
