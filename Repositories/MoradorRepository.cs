using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zelo.Entities;
using Zelo.Context;

namespace Zelo.Repositories
{
    public class MoradorRepository
    {
        private readonly CondominioContext _context;

        public MoradorRepository(CondominioContext context)
        {
            _context = context;
        }

        public void Add(Morador morador)
        {
            _context.Moradores.Add(morador);
            _context.SaveChanges();
        }


    }
}