using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMVC.Models;
using CrudMVC.Data;

namespace CrudMVC.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly ContatoContext contato_Context;
        public ContatoRepository(ContatoContext contatoContext)
        {
            contato_Context = contatoContext;
        }
        public ContatoModel adicionar(ContatoModel contato)
        {
            contato_Context.Contatos.Add(contato);
            contato_Context.SaveChanges();
            return contato; 
        }
    }
}