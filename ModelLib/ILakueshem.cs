namespace Model
{
    public interface ILakueshem
    {
        string NjejesiShquar { get; set; } // trajta e shquar
        string NjejesiPashquar { get; set; } // trajta e pa shquar
        string ShumesiShquar { get; set; }
        string ShumesiPashquar { get; set; }

        Gjinia Gjinia { get; set; }

        Rasa RasatNjejesPashquar { get; set; } // emerore, gjinore, dhanore, kallzore, rrjedhore
        Rasa RasatShumesPashquar { get; set; } // emerore, gjinore, dhanore, kallzore, rrjedhore

        Rasa RasatNjejesShquar { get; set; } 
        Rasa RasatShumesShquar { get; set; } 


        string Sinonimet { get; set; }
        string Antonimet { get; set; }
        string TeNgjashme { get; set; } // fjale me kuptim te afert



    }
}
