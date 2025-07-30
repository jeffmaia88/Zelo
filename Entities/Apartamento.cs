using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zelo.Entities
{
    public class Apartamento
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Bloco { get; set; }
        public string Situacao { get; set; }
    }
}