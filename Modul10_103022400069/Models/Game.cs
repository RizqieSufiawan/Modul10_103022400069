namespace Modul10_103022400069.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public int TahunRilis { get; set; }
        public string Genre { get; set; }
        public Double Rating { get; set; }
        public string[] Platform { get; set; }
        public string[] Mode { get; set; }
        public bool IsOnline { get; set; }
        public int Harga { get; set; }

    }
}
