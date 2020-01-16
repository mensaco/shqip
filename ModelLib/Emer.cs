﻿namespace Model
{
    public class Emer : IFjale, ILakueshem
    {
        public int Id { get; set; }

 
        public string Teksti { get; set; }

        public string Pershkrimet { get; set; } = ""; // zero apo me shume pershkrime te ndara me nje separator mes veti

        public string Shquar { get; set; } // trajta e shquar
        public string PaShquar { get; set; } // trajta e pashquar

        public Lloji Lloji { get; set; }

        public Gjinia Gjinia { get; set; }
        public string Shumesi { get; set; }
        public Rase RasatNjejes { get; set; } = new Rase();
        public Rase RasatShumes { get; set; } = new Rase();

        
        public string Sinonimet { get; set; }  = "";// fjale me kuptim te njejte te ndara me nje separator
        
        public string Antonimet { get; set; }  = "";// fjale me kuptim te kundert  te ndara me nje separator

        public string TeNgjashme { get; set; }  = "";// fjale me kuptim te afert  te ndara me nje separator
        public string KontribuesiID { get; set; }
        
    }

    public enum Lloji
    {
        i_Pervetshem,
        i_Pergjithshem
    }
}