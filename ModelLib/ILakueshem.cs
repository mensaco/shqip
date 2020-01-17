namespace Model
{
    public interface ILakueshem
    {
        string NjejesiShquar { get; set; } // trajta e shquar
        string NjejesiPashquar { get; set; } // trajta e pa shquar
        string ShumesiShquar { get; set; }
        string ShumesiPashquar { get; set; }

        Gjinia Gjinia { get; set; }

        Rase RasatNjejesPashquar { get; set; } // emerore, gjinore, dhanore, kallzore, rrjedhore
        Rase RasatShumesPashquar { get; set; } // emerore, gjinore, dhanore, kallzore, rrjedhore

        Rase RasatNjejesShquar { get; set; } 
        Rase RasatShumesShquar { get; set; } 


        string Sinonimet { get; set; }
        string Antonimet { get; set; }
        string TeNgjashme { get; set; } // fjale me kuptim te afert



    }
}
