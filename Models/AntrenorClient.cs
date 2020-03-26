using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class AntrenorClient
    {
        public int Id { get; set; }
        public int AntrenorId { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Antrenor Antrenor { get; set; }
    }
}
