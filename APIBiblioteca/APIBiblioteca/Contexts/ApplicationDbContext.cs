using APIBiblioteca.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBiblioteca.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {

        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

    }
}
