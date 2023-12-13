using Microsoft.EntityFrameworkCore;
using System;

public class AppDbContext : DbContext
{
	public DbSet<Clientes> cliente { get; set; } = null!;
	public DbSet<Pedidos> pedido { get; set; } = null!;
	public DbSet<Motorista> motorista { get; set; } = null!;
	public DbSet<Produtos> produto { get; set; } = null!;
	public DbSet<Usuario> usuario { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlServer(connectionString: "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Panificadora;Integrated Security=True");
}
