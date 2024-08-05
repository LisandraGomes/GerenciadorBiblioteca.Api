namespace WebApplication1.Request
{
    public class CadastrarEmprestimoRequest
    {
        public int IdLivro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public int QuantidadeDias { get; set; }
    }
}
