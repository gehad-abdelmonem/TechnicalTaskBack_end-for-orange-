using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.DAL.Data.Entity;

namespace TechnicalTask.DAL.Data.Context
{
    public class SWTaskContext:DbContext
    {
        public SWTaskContext(DbContextOptions<SWTaskContext> options) : base(options)
        {

        }
         public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);

            modelBuilder.Entity<Customer>()
            .Property(c => c.Id)
            .ValueGeneratedNever();
        }

    }
}
