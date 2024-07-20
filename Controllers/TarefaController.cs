using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MVC_GerenciadorDeTarefas.Context;
using MVCGerenciadorDeTarefas.Models;

namespace MVC_GerenciadorDeTarefas.Controllers
{
    public class TarefaController : Controller
    {
        private readonly GerenciadorContext _context;

        public TarefaController(GerenciadorContext context)
        {
            _context = context;
        }

        public IActionResult index()
        {

            return View(new List<Tarefa>());
        }

        [HttpGet]
        public IActionResult MostrarTodas()
        {
            var tarefa = _context.Tarefas.ToList();
            return View("index", tarefa);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return RedirectPreserveMethod("index");

        }
        public IActionResult DetalhesTarefa(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return View(tarefa);



        }
        [HttpGet]
        public IActionResult BuscarPorTitulo(string titulo)
        {
            if (titulo.IsNullOrEmpty())
            {
                return NotFound();
            }

            var ListaPorTitulo = _context.Tarefas.Where(t => t.Titulo.Contains(titulo)).ToList();
            return View("index", ListaPorTitulo);
        }
        [HttpGet]
        public IActionResult BuscarPorStatus(EnumStatusTarefa status)
        {


            var ListaPorStatus = _context.Tarefas.Where(t => t.Status == status).ToList();


            return View("Index", ListaPorStatus);
        }
        [HttpGet]
        public IActionResult BuscarPorData(DateTime data)
        {


            var ListaPorData = _context.Tarefas.Where(t => t.Data == data).ToList();
            return View("index", ListaPorData);
        }
        public IActionResult AlteraParaFinalizada(int id){
        var TarefaBD = _context.Tarefas.Find(id);

        TarefaBD.Status = EnumStatusTarefa.Finalizado;
        _context.SaveChanges();
        return RedirectPreserveMethod("index");
        }
        public IActionResult Delete(int id){
            var deletavel = _context.Tarefas.Find(id);
            _context.Tarefas.Remove(deletavel);
            _context.SaveChanges();
            return RedirectPreserveMethod("index");

            

        }




    }
}