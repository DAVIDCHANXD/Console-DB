using david.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace david.Funciones
{
    public class applitationDBContext: DbContext
    {
        //crear un metodo para conectarse a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"datasource =127.0.0.1; Port =3306; Username =root; Password=;Database=prueba_david;");
        }

        //mapeo de onjetos a tablas DB
        public DbSet<Persona> Persona { get; set; }
       public DbSet<Ciudad> Ciudades { get; set; }


    }
}
