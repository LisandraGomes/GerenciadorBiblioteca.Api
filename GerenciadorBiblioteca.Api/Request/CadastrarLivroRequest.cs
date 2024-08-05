namespace WebApplication1.Request
{
    public class CadastrarLivroRequest
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
