using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Rasa : IRasa
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Emerore { get; set; }
        [MaxLength(30)]
        public string Gjinore { get; set; }
        [MaxLength(30)]
        public string Dhanore { get; set; }
        [MaxLength(30)]
        public string Kallzore { get; set; }
        [MaxLength(30)]
        public string Rrjedhore { get; set; }
    }
}