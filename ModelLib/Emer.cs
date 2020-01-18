using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Emer : IFjale, ILakueshem
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Teksti { get; set; }

        [MaxLength(511)]
        public string Pershkrimet { get; set; } = ""; // zero apo me shume pershkrime te ndara me nje separator mes veti

        [MaxLength(30)]
        public string NjejesiShquar { get; set; } = ""; // trajta e shquar

        [MaxLength(30)]
        public string NjejesiPashquar { get; set; }  = "";// trajta e pashquar
        [MaxLength(30)]
        public string ShumesiShquar { get; set; } = "";
        [MaxLength(30)]
        public string ShumesiPashquar { get; set; } = "";

        public Gjinia Gjinia { get; set; }

        public Lloji Lloji { get; set; }

        public Rasa RasatNjejesPashquar { get; set; } = new Rasa();
        public Rasa RasatShumesPashquar { get; set; } = new Rasa();

        public Rasa RasatNjejesShquar { get; set; } = new Rasa();
        public Rasa RasatShumesShquar { get; set; } = new Rasa();


        [MaxLength(100)]
        public string Sinonimet { get; set; }  = "";// fjale me kuptim te njejte te ndara me nje separator
        [MaxLength(100)]
        public string Antonimet { get; set; }  = "";// fjale me kuptim te kundert  te ndara me nje separator
        [MaxLength(100)]
        public string TeNgjashme { get; set; }  = "";// fjale me kuptim te afert  te ndara me nje separator
        [MaxLength(30)]
        public string KontribuesiID { get; set; }
        public KategoriaGramatikore KategoriaGramatikore { get => KategoriaGramatikore.Emer; set {  } }
    }
}
