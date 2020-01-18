using System.ComponentModel.DataAnnotations;

namespace Model
{
    //todo : komento

    public class Fjale : IFjale
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Teksti { get; set; }
        [MaxLength(511)]
        public string Pershkrimet { get; set; }
        [MaxLength(30)]
        public string KontribuesiID { get; set; } // Id e kontribuesit
        public KategoriaGramatikore KategoriaGramatikore { get; set; }
    }
}