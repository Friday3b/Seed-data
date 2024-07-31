using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hometask_crud.AppDbContex;


namespace hometask_crud.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Page { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        public Category? category { get; set; }
        public Author? author { get; set; }


    }
}
