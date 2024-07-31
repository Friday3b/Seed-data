using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hometask_crud.Model;
using Microsoft.EntityFrameworkCore;

namespace hometask_crud.AppDbContex
{


    public class ApplicationDbContex : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G936QCF;Initial Catalog=Library0101;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


        public DbSet<Book> books1 { get; set; }
        public DbSet<Author> authors1 { get; set; }
        public DbSet<Category> categories1 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Author>().
                HasData(
                new Author { Id = 1, FirstName = "Daniel", LastName = "Defoe" },
                new Author { Id = 2, FirstName = "Lewis", LastName = "Carroll" },
                new Author { Id = 3, FirstName = "Veda", LastName = "Vyas" }
                );


            modelBuilder.Entity<Category>().
                HasData(
                 new Category { Id =1 , Name = "Non-Fiction" } ,
                 new Category { Id = 2, Name = "Poems" },
                 new Category { Id = 3, Name = "Western" }


                );
        
            modelBuilder.Entity<Book>().
                HasData(
                new Book { Id = 1, Name = "Adventures of Robinson Crusoe", Page = "100", AuthorId = 1 , CategoryId = 1},
                new Book { Id = 2, Name = "Alice in Wonderland", Page = "150"  , AuthorId =2  , CategoryId = 2 },
                new Book { Id = 3, Name = "Bhagwat Gita", Page = "300" , AuthorId = 3   , CategoryId = 3}
                );
        }




                
        

    }
}
