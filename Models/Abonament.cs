using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Abonament
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public double Pret { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set;  }
        public List<Client> Client { get; set; }
    }
}
