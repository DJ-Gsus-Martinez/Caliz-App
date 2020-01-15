using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caliz.API.Models
{
    public class User
    {
        private User context;

        public int IDUser { get; set; }

        public int IDRutine { get; set; }

        public int IDProgressions{ get; set; }
        
        public string Name { get; set; }

        public string SecondName { get; set; }

        public DateTime Birthdate{ get; set; }
        public string email { get; set; }
        public string Goals{ get; set; }
    }
}
