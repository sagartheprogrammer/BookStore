using System.Collections.Generic;
using System.Linq;
using WebGentle.BookStore.Model;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetABook(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authourname)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authourname)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {   
                new BookModel(){Id = 1, Title = "title1", Author = "Authour1", Description = "Description1"},
                new BookModel(){Id = 2, Title = "title2", Author = "Authour2", Description = "Description2"},
                new BookModel(){Id = 3, Title = "title3", Author = "Authour3", Description = "Description3"},
                new BookModel(){Id = 4, Title = "title4", Author = "Authour4", Description = "Description4"},
                new BookModel(){Id = 5, Title = "title5", Author = "Authour5", Description = "Description5"}
            };
        }
    }
}
