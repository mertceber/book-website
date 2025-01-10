using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SUMMARIES.Data
{
    public class BookService : IBookService
    {
        private readonly BookDbContext _context;

        // Yapıcı metot
        public BookService(BookDbContext context)
        {
            _context = context;
        }

        public void AddBook(Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();  // Değişiklikleri veritabanına kaydedin
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(n => n.Id == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();  // Değişiklikleri veritabanına kaydedin
            }
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();  // Veritabanından tüm kitapları al
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(n => n.Id == id);  // Veritabanından id'ye göre kitap al
        }

        public void UpdateBook(int id, Book newBook)
        {
            var oldBook = _context.Books.FirstOrDefault(n => n.Id == id);

            if (oldBook != null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Description = newBook.Description;
                oldBook.Rate = newBook.Rate;
                oldBook.DateStart = newBook.DateStart;
                oldBook.DateRead = newBook.DateRead;

                _context.SaveChanges();  // Değişiklikleri veritabanına kaydedin
            }
        }
    }
}
