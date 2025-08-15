using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zelo.Repositories;
using Zelo.Models;
using Zelo.Entities;

namespace Zelo.Services
{
    public class ApartamentoServices
    {
        private readonly ApartamentoRepository _repository;

        public ApartamentoServices(ApartamentoRepository repository)
        {
            _repository = repository;
        }

        public Apartamento Create(ApartamentoRequest aprequest)
        {
            var Apartamento = new Apartamento
            {
                Numero = aprequest.Numero,
                Situacao = aprequest.Situacao,
                Bloco = aprequest.Bloco,
                Vaga = aprequest.Vaga
            };

            _repository.Add(Apartamento);
            return Apartamento;
        }

        public List<Apartamento> GetAll()
        {
            return _repository.GetAll();
        }

    }
}