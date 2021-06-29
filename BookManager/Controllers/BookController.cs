using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.ModelBinding;
using BookManager.Models;


namespace BookManager.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public String HelloTeacher(string month, string year)
        {
            return "HUTECH2021"+ month + "/" + year;
        }

        public ActionResult ListBook()
        {
            List<string> listbook = new List<string>();
            listbook.Add("Sách 129");
            listbook.Add("Sách 19");
            listbook.Add("Sách 13");
            listbook.Add("Sách 11");
            listbook.Add("Sách 10");

            ViewBag.Books = listbook;


            return View();
        }

        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML", "Ông X", "/Content/images/b1.jpg"));
            books.Add(new Book(2, "HTML", "Ông Y", "/Content/images/b2.jpg"));
            books.Add(new Book(3, "HTML", "Ông Z", "/Content/images/b3.jpg"));
            return View(books);
        }
        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int id, string title, string author, string image_url)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML", "Ông X", "/Content/images/b1.jpg"));
            books.Add(new Book(2, "HTML", "Ông Y", "/Content/images/b2.jpg"));
            books.Add(new Book(3, "HTML", "Ông Z", "/Content/images/b3.jpg"));

            if (id == null)
            {
                return HttpNotFound();
            }
            
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = title;
                    b.Author = author;
                    b.Image_url = image_url;
                    break;
                }
            }

            
            return View("ListBookModel",books);


        }

        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML", "Ông X", "/Content/images/b1.jpg"));
            books.Add(new Book(2, "HTML", "Ông Y", "/Content/images/b2.jpg"));
            books.Add(new Book(3, "HTML", "Ông Z", "/Content/images/b3.jpg"));

            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }

            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);

        }


        public ActionResult CreateBook()
        {
            return View();
    }
        
        



    }
}