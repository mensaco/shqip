using System.Collections.Generic;

namespace Model
{
    public interface IFjale
    {
        public int Id { get; set; }
        public string KontribuesiID { get; set; } // perdoruesi i cili e futi fjalen ne sistem
        public string Teksti { get; set; }
        public string Pershkrimet { get; set; } // lista e pershkrimeve te mundeshme
        

    }
}
