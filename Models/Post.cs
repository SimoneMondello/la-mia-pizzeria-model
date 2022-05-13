namespace NetCore_01.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Titolo { get; set; }

        public string Ingredienti { get; set; }

        public string Immagine { get; set; }

        public Post()
        { 
        }

        public Post(int id, string titolo, string ingredienti, string immagine)
        {
            this.Id = id;
            this.Titolo = titolo;
            this.Ingredienti = ingredienti;
            this.Immagine = immagine;
        }
    }
}
