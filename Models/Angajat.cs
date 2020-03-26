using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Angajat
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public double Salariu { get; set; }
        public int Telefon { get; set; }
        public int[][] Poza { get; set; }
        public virtual Antrenor Antrenor { get; set; }

    }
}
