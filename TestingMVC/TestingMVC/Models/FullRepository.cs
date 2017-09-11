using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingMVC.Models
{
    public class FullRepository : Repository
    {
        public List<Book> GetAll()
        {
            return new List<Book>
            {
                new Book { Genre = "Fiction", Id = 1, Name = "Siapa Saya", Price = 200000 },
                new Book { Genre = "Fiction", Id = 2, Name = "Siapa Saya 2", Price = 100000 },
                new Book { Genre = "Mistery", Id = 3, Name = "The Pilgrimage", Price = 400000 },
                new Book { Genre = "Non-Fiction", Id = 4, Name = "Multatuli", Price = 500000 },
                new Book { Genre = "Health", Id = 5, Name = "Sehat Setiap Pagi", Price = 4000 },
                new Book { Genre = "Music", Id = 6, Name = "Learning Guitar in 10 minutes", Price = 240000 },
                new Book { Genre = "Religion", Id = 7, Name = "Who Am I?", Price = 800000 },
                new Book { Genre = "Self-Imprvement", Id = 3, Name = "Finding Success", Price = 300000 },
                new Book { Genre = "Kids", Id = 3, Name = "Berhitung Yuk", Price = 20000 }
            };
        }
    }
}