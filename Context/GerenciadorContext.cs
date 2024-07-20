using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCGerenciadorDeTarefas.Models;

namespace MVC_GerenciadorDeTarefas.Context
{
    public class GerenciadorContext : DbContext
    {
       public GerenciadorContext(DbContextOptions<GerenciadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
} 
    
