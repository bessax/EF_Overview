using Microsoft.EntityFrameworkCore;

namespace EF_Overview;
public class TarefasContext:DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tarefas_BD;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
