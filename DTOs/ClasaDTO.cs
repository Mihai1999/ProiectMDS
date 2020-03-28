using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.DTOs
{
    public class ClasaDTO
    {
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public int AntrenorId { get; set; }
        public List<int> ClasaClientId { get; set; }
    }
}
