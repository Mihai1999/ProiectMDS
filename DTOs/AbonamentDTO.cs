using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.DTOs
{
    public class AbonamentDTO
    {
        public string Denumire { get; set; }
        public double Pret { get; set; }
        public List<int> ClientId { get; set; }
    }
}
