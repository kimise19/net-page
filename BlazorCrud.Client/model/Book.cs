namespace BlazorCrud.Client.model
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int AnioPublicacion { get; set; }
        public int AutorId { get; set; }
        public bool Estado { get; set; }
    }
}
