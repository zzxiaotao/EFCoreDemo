using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
       
        //public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(ConnectionString);
            //}
            //注入Sql链接字符串
            //optionsBuilder.UseSqlServer(@"Server=.;Database=Bigcock;User ID=sa;Password=123456;Trusted_Connection=False;");
        }

        public DbSet<User> Users { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("Id")
        //            .ValueGeneratedNever();
        //    });
        //}
    }
}
