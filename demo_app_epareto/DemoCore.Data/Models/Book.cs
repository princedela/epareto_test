using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public string Year { get; set; }
    }
}
