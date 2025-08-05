using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zelo.Models.Enums;

namespace Zelo.Entities
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public TipoMorador TipoMorador { get; set; }
        public int ApartamentoId { get; set; }
        public Apartamento Apartamento { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    

    }
}