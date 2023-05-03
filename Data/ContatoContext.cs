using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contatos {get; set;}
    }
}