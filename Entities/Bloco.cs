using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zelo.Entities
{
    public class Bloco
    {
        public int Id { get; set; }
        public string Nome { get; set; }    
        public List<Apartamento> Apartamentos { get; set; }

    }
}