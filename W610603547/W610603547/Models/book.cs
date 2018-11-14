using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace W610603547.Models
{
    public class Bookcontext: DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
    public class Book
    {
        public String Bookname { get; set; }
        public String ISBN { get; set; }
        public int Price { get; set; }

    }
}