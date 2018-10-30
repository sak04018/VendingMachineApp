using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace VendingMachineApp
{
    class VendingModel : DbContext
    {
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Vending2Db;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionNumber)
                .HasName("Transaction_Number");

                entity.Property(e => e.TransactionNumber)
                .ValueGeneratedOnAdd();

                entity.ToTable("Transactions");
            });
        }
    }
}
