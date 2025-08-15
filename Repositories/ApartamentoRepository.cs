using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zelo.Context;
using Zelo.Entities;

namespace Zelo.Repositories
{
    public class ApartamentoRepository
    {
        private readonly CondominioContext _context;

        public ApartamentoRepository(CondominioContext context)
        {
            _context = context;
        }

        public void Add(Apartamento apartamento)
        {
            _context.Apartamentos.Add(apartamento);
            _context.SaveChanges();
        }

        public Apartamento GetById(int id)
        {
            return _context.Apartamentos.FirstOrDefault(a => a.Id == id);
        }

        public List<Apartamento> GetAll()
        {
            return _context.Apartamentos.ToList();
        }

    }



}