using Microsoft.EntityFrameworkCore;
using SuddenAmbiente.Models;

namespace SuddenAmbiente.DataAccess
{
	public class SuddenDataContext : DbContext
	{
		public DbSet<Imovel> Imoveis { get; set; }

		public DbSet<Corretor> Corretores { get; set; }

		public DbSet<Interesse> Interesses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(@"Data Source=C:\sqlite\principal.db;");
		}
	}
}