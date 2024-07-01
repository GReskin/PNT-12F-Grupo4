using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;

using System.Collections.Generic;


namespace App.Context
{
	public class ClasesDatabaseContext : DbContext
	{
		public ClasesDatabaseContext(DbContextOptions<ClasesDatabaseContext>
		options) : base(options)
		{
		}
		public DbSet<Usuario> Usuarios { get; set; } = default!;
        public DbSet<Clase> Clase { get; set; } = default!;
        public DbSet<Curso>? Cursos { get; set; }

    }
}