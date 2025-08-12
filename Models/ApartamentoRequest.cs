using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zelo.Models.Enums;
using Zelo.Entities;

namespace Zelo.Models
{
    public class ApartamentoRequest
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public Situacao Situacao { get; set; }
        public string Bloco { get; set; }      
        public Morador? Morador { get; set; }
        public bool Vaga{ get; set; }

    }
}