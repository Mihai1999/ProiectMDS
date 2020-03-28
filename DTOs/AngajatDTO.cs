using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.DTOs
{
    public class AngajatDTO
    {
        public string Nume { get; set; }
        public string Job { get; set; }
        public double Salariu { get; set; }
        public int Telefon { get; set; }
        public int[][] Poza { get; set; }
    }
}
