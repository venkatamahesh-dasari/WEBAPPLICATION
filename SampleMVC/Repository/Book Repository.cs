using Microsoft.EntityFrameworkCore;
using SampleMVC.Data;
using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVC.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdatedOn = DateTime.UtcNow
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allbooks = await _context.Books.ToListAsync();
            if (allbooks?.Any() == true)
            {
                foreach (var book in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Id = book.Id,
                        Author = book.Author,
                        Description = book.Description,
                        Title = book.Title,
                        TotalPages = book.TotalPages,
                    });
                }
            }
            return books;
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author == authorName).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Nitish", Description = "Description for MVC", TotalPages=100 },
                new BookModel() { Id = 2, Title = "C#", Author = "Randy", Description = "Description for C#", TotalPages=400 },
                new BookModel() { Id = 3, Title = "Java", Author = "John", Description = "Description for Java", TotalPages=300 },
                new BookModel() { Id = 4, Title = "Php", Author = "Mandy", Description = "Description for Php", TotalPages=200 },
                new BookModel() { Id = 5, Title = "Azure DevOps", Author = "Ram", Description = "Description for Azure DevOps", TotalPages=200 },
                new BookModel() { Id = 6, Title = "C", Author = "San", Description = "Description for C", TotalPages=200 },
                new BookModel() { Id = 7, Title = "Python", Author = "Sandeep", Description = "Description for Python", TotalPages=200 },
                new BookModel() { Id = 8, Title = "MySQL", Author = "Micky", Description = "Description for MySQL", TotalPages=200 },
            };
        }
    }
}
