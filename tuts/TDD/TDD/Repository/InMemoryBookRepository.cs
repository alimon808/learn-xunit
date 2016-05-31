using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;

namespace TDD.Repository
{
    public class InMemoryBookRepository : IBookRepository
    {
        List<Book> _books;

        public InMemoryBookRepository()
        {
            _books = new List<Book>()
            {
                new Book {
                    Id = 1,
                    Name = "Moby Dick",
                    Genre = "Fiction",
                    Price = 12.50m
                },
                new Book {
                    Id = 2,
                    Name = "War and Peace",
                    Genre = "Fiction",
                    Price = 17m
                },
                new Book {
                    Id = 3,
                    Name = "Chemistry",
                    Genre = "Non-Fiction",
                    Price = 35m
                },
                new Book {
                    Id = 4,
                    Name = "Biology",
                    Genre = "Non-Fiction",
                    Price = 35m
                },
                new Book {
                    Id = 5,
                    Name = "Cryptonomicon",
                    Genre = "Fiction",
                    Price = 15m
                },
                new Book {
                    Id = 6,
                    Name = "In Search of Lost Time",
                    Genre = "Fiction",
                    Price = 15m
                },
            };
        }
        public List<Book> GetAll()
        {
            return _books;
        }
    }
}
