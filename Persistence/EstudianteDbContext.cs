using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class EstudianteDbContext : DbContext
    {
        public DbSet <Estudiante> Estudiante { get; set; }

        public EstudianteDbContext(DbContextOptions<EstudianteDbContext> opciones) : base(opciones)
        { }
    }
}
