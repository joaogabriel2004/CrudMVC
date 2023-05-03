using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMVC.Models;

namespace CrudMVC.Repository
{
    public interface IContatoRepository
    {
        ContatoModel adicionar(ContatoModel contato);
    }
}