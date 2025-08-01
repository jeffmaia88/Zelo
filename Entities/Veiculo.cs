using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zelo.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int MoradorId { get; set; }
        public Morador Morador { get; set; }
    }
}