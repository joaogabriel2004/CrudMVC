using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMVC.Models;
using CrudMVC.Repository;

namespace CrudMVC.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepository contato_Repository;
    public ContatoController(IContatoRepository contatoRepository)
    {
        contato_Repository = contatoRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
     public IActionResult Criar()
    {
        return View();
    }
     public IActionResult Editar()
    {
        return View();
    }
     public IActionResult VerificarDeletar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Criar(ContatoModel contato){
        contato_Repository.adicionar(contato);
        return RedirectToAction("Index");
    }

}
