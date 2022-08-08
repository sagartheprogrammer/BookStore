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
            return View();
        }

        public BookModel GetABook(int id)
        {
            return _bookRepository.GetABook(id);
        }

        public List<BookModel> SearchBooks(string boookName, string authourName)
        {
            return _bookRepository.SearchBook(boookName, authourName);
        }
    }
}
