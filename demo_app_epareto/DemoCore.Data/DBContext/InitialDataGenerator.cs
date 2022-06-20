using System;
using System.Collections.Generic;
using DemoCore.Data.Models;

namespace DemoCore.Data.DBContext
{
    public static class InitialDataGenerator
    {
   
        public static void AddProductsToCache(AppDBContext context)
        {
            //Genres
            var finance = new Genre() { Id = 1, Name = "Finance" };
            context.Genres.Add(finance);
            var fantasy = new Genre() { Id = 2, Name = "Fantasy" };
            context.Genres.Add(fantasy);
            var religion = new Genre() { Id = 3, Name = "Religion" };
            context.Genres.Add(religion);
            var mystery = new Genre() { Id = 4, Name = "Mystery" };
            context.Genres.Add(mystery);
            var nonFiction = new Genre() { Id = 5, Name = "Non Fiction" };
            context.Genres.Add(nonFiction);
            var science = new Genre() { Id = 6, Name = "Non Fiction" };
            context.Genres.Add(science);

            //Authors;
            var neil = new Author() { Id = 1, Name = "Neil Gaiman" };
            var jen = new Author() { Id = 2, Name = "Jen Sincero" };
            var dawkins = new Author() { Id = 3, Name = "Richard Dawkins" };
            var graham = new Author() { Id = 4, Name = "Benjamin Graham" };
            var fry = new Author() { Id = 5, Name = "Stephen Fry" };
            context.Authors.Add(neil); 
            context.Authors.Add(jen);
            context.Authors.Add(dawkins);
            context.Authors.Add(graham);
            context.Authors.Add(fry);

            //Books
            context.Books.Add(new Book() { 
                Id = 1, 
                Title = "Mythos",
                ISBN = "1-4028-9462-7",
                Year = "2013",
                Authors = new List<Author> {fry },
                Genres = new List<Genre> { religion}
            });  context.Books.Add(new Book() { 
                Id = 2, 
                Title = "The Intelligent Investor",
                ISBN = "1-2011-9462-7",
                Year = "1976",
                Authors = new List<Author> { graham },
                Genres = new List<Genre> { finance }
            });
            
            context.Books.Add(new Book() { 
                Id = 3, 
                Title = "You Are A Badass",
                ISBN = "1-42434-9462-7",
                Year = "2013",
                Authors = new List<Author> { jen },
                Genres = new List<Genre> { nonFiction }
            }); 
            
            context.Books.Add(new Book() { 
                Id = 4, 
                Title = "The Selfish Gene",
                ISBN = "1-5643-9462-7",
                Year = "2008",
                Authors = new List<Author> { dawkins },
                Genres = new List<Genre> { science }
            });
            context.Books.Add(new Book() { 
                Id = 5, 
                Title = "The Sandman",
                ISBN = "1-2476-9462-7",
                Year = "2020",
                Authors = new List<Author> {neil },
                Genres = new List<Genre> { fantasy }
            });
            context.SaveChanges();
        }
    }
}
