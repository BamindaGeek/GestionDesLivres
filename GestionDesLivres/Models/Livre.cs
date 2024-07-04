namespace GestionDesLivres.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string author_key { get; set; }
        public string? title { get; set; }
        public string? author_name { get; set; }
        public string? first_publish_year { get; set; }
        public string? publisher { get; set; }
        public string? contributor { get; set; }

    }
}
