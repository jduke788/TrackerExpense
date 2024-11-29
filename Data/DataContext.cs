using TrackerExpense.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace TrackerExpense.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseModel>().HasData
            (
                new ExpenseModel()
                {
                    Id = 1,
                    Title = "Transport",
                    Description = "Petrol at Tesco",
                    Amount = 65.0M,
                    CreatedAt = DateTime.UtcNow
                },
                new ExpenseModel()
                {
                    Id = 2,
                    Title = "Eating out",
                    Description = "Meal deal from Tesco for lunch",
                    Amount = 3.6M,
                    CreatedAt = DateTime.UtcNow.AddHours(1)
                }
                , new ExpenseModel()
                {
                    Id = 3,
                    Title = "Groceries",
                    Description = "Weekly shop - Tesco",
                    Amount = 84.32M,
                    CreatedAt = DateTime.UtcNow.AddHours(2)
                }

            );


        }

        public DbSet<ExpenseModel> Expenses { get; set; }
    }
}
