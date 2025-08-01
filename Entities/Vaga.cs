using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zelo.Entities
{
    public class Vaga
    {
        public int Id { get; set; }
        public int ApartamentoId { get; set; }
        public Apartamento Apartamento { get; set; }
        public int MoradorId { get; set; }
        public Morador Morador { get; set; }
        public TipoVaga TipoVaga { get; set; }
    }
}