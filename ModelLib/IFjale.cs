using System;

namespace Model
{
    public interface IFjale
    {
        int Id { get; set; }
        string KontribuesiID { get; set; } // perdoruesi i cili e futi fjalen ne sistem
        KategoriaGramatikore KategoriaGramatikore { get; set; }
        string Teksti { get; set; }
        string Pershkrimet { get; set; } // lista e pershkrimeve te mundeshme


    }
}
