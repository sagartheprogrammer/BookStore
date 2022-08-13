using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebGentle.BookStore.Model;
using WebGentle.BookStore.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();    
        }
        
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetABook(int id)
        {
            var singleBook = _bookRepository.GetABook(id);
            return View(singleBook);
        }

        public List<BookModel> SearchBooks(string boookName, string authourName)
        {
            return _bookRepository.SearchBook(boookName, authourName);
        }
    }
}
