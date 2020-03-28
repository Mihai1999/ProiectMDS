using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.DTOs
{
    public class AntrenorDTO
    {
        public int AngajatId { get; set; }
        public List<int> AntrenorClientId { get; set; }
        public List<int> ClasaId { get; set; }
    }
}
