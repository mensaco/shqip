namespace Model
{
    public class Emer : IFjale, ILakueshem
    {
        public int Id { get; set; }

 
        public string Teksti { get; set; }

        public string Pershkrimet { get; set; } = ""; // zero apo me shume pershkrime te ndara me nje separator mes veti

        public string NjejesiShquar { get; set; } = ""; // trajta e shquar
        public string NjejesiPashquar { get; set; }  = "";// trajta e pashquar

        public string ShumesiShquar { get; set; } = "";
        public string ShumesiPashquar { get; set; } = "";

        public Gjinia Gjinia { get; set; }

        public Lloji Lloji { get; set; }

        public Rase RasatNjejesPashquar { get; set; } = new Rase();
        public Rase RasatShumesPashquar { get; set; } = new Rase();

        public Rase RasatNjejesShquar { get; set; } = new Rase();
        public Rase RasatShumesShquar { get; set; } = new Rase();



        public string Sinonimet { get; set; }  = "";// fjale me kuptim te njejte te ndara me nje separator
        
        public string Antonimet { get; set; }  = "";// fjale me kuptim te kundert  te ndara me nje separator

        public string TeNgjashme { get; set; }  = "";// fjale me kuptim te afert  te ndara me nje separator

        public string KontribuesiID { get; set; }
        
    }
}
