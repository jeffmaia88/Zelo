using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zelo.Entities;

namespace Zelo.Context
{
    public class CondominioContext : DbContext
    {
        public CondominioContext(DbContextOptions<CondominioContext> options) : base(options)
        {

        }

        public DbSet<Morador> Moradores { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }    
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}