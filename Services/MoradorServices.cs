using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zelo.Models;
using Zelo.Entities;
using Zelo.Repositories;

namespace Zelo.Services
{
    public class MoradorServices
    {
        private readonly MoradorRepository _moradorRepository;
        private readonly ApartamentoRepository _apRepository;

        public MoradorServices(MoradorRepository moradorRepository, ApartamentoRepository apRepository)
        {
            _moradorRepository = moradorRepository;
            _apRepository = apRepository;
        }

        public Morador Create(MoradorRequest moradorRequest)
        {
            var apartamento = _apRepository.GetById(moradorRequest.ApartamentoId);
            if (apartamento == null)
            {
                throw new Exception("Apartamento não encontrado");
            }

            var morador = new Morador
            {
                Nome = moradorRequest.Nome,
                Cpf = moradorRequest.Cpf,
                Email = moradorRequest.Email,
                Telefone = moradorRequest.Telefone,
                TipoMorador = moradorRequest.TipoMorador,
                Apartamento = apartamento

            };

            _moradorRepository.Add(morador);
            return morador;


        }

    }
}