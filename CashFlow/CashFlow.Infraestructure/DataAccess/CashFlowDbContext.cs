using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infraestructure.DataAccess
{
    public class CashFlowDbContext:DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=cashflowdb;Uid=root;Pwd=Youngmull4!;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 35));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
