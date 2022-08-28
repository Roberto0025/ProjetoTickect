using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTickect.Entidades
{
    public class Context : DbContext
    {
        public Context() : base("BD")
        { }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Tickect> tickects { get; set; }
    }
}
