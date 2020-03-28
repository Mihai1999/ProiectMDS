using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.DTOs
{
    public class ClientDTO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public int AbonamentId { get; set; }
        public List<int> ClasaClientId { get; set; }
        public List<int> AntrenorClientId { get; set; }
    }
}
