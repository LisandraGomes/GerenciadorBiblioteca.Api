namespace GerenciadorBiblioteca.Api.Response
{
    public class EmprestimoResponse
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolver { get; set; }
        public int AtrasoEmDias { get; set; }
    }
}
