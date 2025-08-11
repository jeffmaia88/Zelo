using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zelo.Models.Enums;


namespace Zelo.Entities
{
    public class Apartamento
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Situacao { get; set; }
        public int BlocoId { get; set; }
        public Bloco Bloco { get; set; }
      
        public Morador? Morador { get; set; }
        public List<Vaga> Vagas { get; set; }

    }
}