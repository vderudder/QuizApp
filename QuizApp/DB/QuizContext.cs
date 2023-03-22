using Microsoft.EntityFrameworkCore;
using QuizApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DB
{
    public partial class QuizContext : DbContext
    {
        public virtual DbSet<Prueba> Pruebas { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost:5433;Database=db_test;Username=postgres;Password=admin");
            }
        }

        public class Prueba
        {
            public int PruebaId { get; set; }
            public string Pregunta { get; set; }
        }
    }
}
