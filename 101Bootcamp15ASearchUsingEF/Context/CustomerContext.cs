using _101Bootcamp15ASearchUsingEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101Bootcamp15ASearchUsingEF.Context
{
    internal class CustomerContext : DbContext
    {

        public CustomerContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO - build context
           // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Customer> Customers { get; set; }

    }
}
