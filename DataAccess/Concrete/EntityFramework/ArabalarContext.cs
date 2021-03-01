using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ArabalarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=arabalar;trusted_Connection=true");
            
        }
        public DbSet<Car> car { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<CarColor> carcolor { get; set; }
        public DbSet<Rental> rentals { get; set; }
        public DbSet<Customer> customers { get; set; }
        
        public DbSet<CarImage> carimage { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
