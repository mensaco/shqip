using System.Collections.Generic;

namespace Model
{
    public interface ILakueshem
    {
        string Shquar { get; set; } // trajta e shquar
        string PaShquar { get; set; } // trajta e pa shquar
        Gjinia Gjinia { get; set; }
        string Shumesi { get; set; }

        Rase RasatNjejes { get; set; } // emerore, gjinore, dhanore, kallzore, rrjedhore
        Rase RasatShumes { get; set; } // emerore, gjinore, dhanore, kallzore, rrjedhore

        string Sinonimet { get; set; }
        string Antonimet { get; set; }
        string TeNgjashme { get; set; } // fjale me kuptim te afert



    }

    public enum Gjinia
    {
        Femrore,
        Mashkullore,
        Neutrale // per fjale arkaike apo krahinarizma eventuale
    }
}
