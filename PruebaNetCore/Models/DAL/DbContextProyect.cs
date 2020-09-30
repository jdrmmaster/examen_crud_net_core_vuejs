using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNetCore.Models
{
    public class DbContextProyect : DbContext
    {

        public DbContextProyect(DbContextOptions<DbContextProyect> options): base(options)
        {

        }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<TipoPermiso> TipoPermisos { get; set; }


    }
}
