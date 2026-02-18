using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Caifanes.Models
{
    public class Album
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public List<string> Songs { get; set; }
    }
}
