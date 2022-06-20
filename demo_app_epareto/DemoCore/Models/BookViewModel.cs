using System;
using System.Linq;
using DemoCore.Data.Models;

namespace DemoCore.Models
{
    public class BookViewModel
    {
        public BookViewModel()
        {
        }
        public BookViewModel(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            ISBN = book.ISBN;
            Authors = string.Join(",", book.Authors.Select(s => s.Name));
            Genres = string.Join(",", book.Genres.Select(s => s.Name));
            Year = book.Year;
        }
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Authors { get; set; } = "";
        public string Genres { get; set; }
        public string Year { get; set; }

    }
}
