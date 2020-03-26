using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fitness.Models;

namespace Fitness.Context
{
    public class Context : DbContext
    {
        public DbSet<Abonament> Abonamente { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Antrenor> Antrenori { get; set; }
        public DbSet<AntrenorClient> AntrenoriClienti { get; set; }
        public DbSet<Clasa> Clase { get; set; }
        public DbSet<ClasaClient> ClaseClienti { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Echipament> Echipamente { get; set; }
        

        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
            {
                optionsBuilder.UseSqlServer(@"Server=.\;Database=Fitness;Trusted_Connection=True;");

            }

        }
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {


        }

    }
}
