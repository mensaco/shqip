using System.Collections.Generic;

namespace Model
{
 //todo : komento
    
    public class Fjale : IFjale
    {
        public int Id { get; set; }
        public string Teksti { get; set; }
        public string Pershkrimet { get; set; }
        public string KontribuesiID { get; set; } // Id e kontribuesit
    }
}