using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProyectoFinal23BM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23BM.Context
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server=localhost; database= ProyectoDb23BM; user=root; password=Luz123456789");
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol>Roles { get; set; }
    }
}
