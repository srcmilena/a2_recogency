using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using site.Models;

namespace site.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // String de conexão com o banco de dados
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=MILENA-PC\SQLEXPRESS;Initial Catalog=site_m03; App=EntityFramework&quot; Integrated Security=True");
        }
        // Tabelas
        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<AtendimentoContato> Atendimento { get; set; }
    }
}
