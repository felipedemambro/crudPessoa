using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudPessoa.Models;

namespace crudPessoa.Data
{
    public class crudPessoaContext : DbContext
    {
        public crudPessoaContext (DbContextOptions<crudPessoaContext> options)
            : base(options)
        {
        }

        public DbSet<crudPessoa.Models.Pessoa> Pessoa { get; set; }
    }
}
