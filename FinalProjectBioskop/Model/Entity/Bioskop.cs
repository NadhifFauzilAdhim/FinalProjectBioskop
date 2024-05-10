using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBioskop.Model.Entity
{
    public class Bioskop
    {
        public string Identity { get; set; }
        public string FilmID { get; set; }
        public string Time { get; set; }
        public string Cusname { get; set; }
        public string Filmname { get; set; }
        public string Harga { get; set; }
        public string SeatNumber { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public string Balance { get; set; }
    }
    
}
