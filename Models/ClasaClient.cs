using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class ClasaClient
    {
        public int Id { get; set; }
        public int ClasaId { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Clasa Clasa { get; set; }
    }
}
