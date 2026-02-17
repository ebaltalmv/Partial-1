using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Caifanes.Models
{
    public class ConcertModel
    {
        public string ImageUrl { get; set; } = "concert_logo.png";
        public string Date { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
    }
}
