using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Lms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lms.Controllers
{
    /// <summary>
    /// The books controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooksController"/> class.
        /// </summary>
        public BooksController()
        {
        }

        /// <summary>
        /// Gets all books.
        /// </summary>
        /// <returns>The all books.</returns>
        [Route("all")]
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        /// <summary>
        /// Gets the available books.
        /// </summary>
        /// <returns>The available books.</returns>
        [Route("available")]
        public IEnumerable<Book> GetAvailableBooks()
        {
            return new List<Book>();
        }

        /// <summary>
        /// Posts the book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>The http response message.</returns>
        [Route("save")]
        public HttpResponseMessage PostBook(Book book)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Puts the book.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="book">The book.</param>
        /// <returns>
        /// The http response message.
        /// </returns>
        [Route("{id}/update")]
        public HttpResponseMessage PutBook(int id, Book book)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Deletes the book.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The http response message.</returns>
        [Route("{id}/delete")]
        public HttpResponseMessage DeleteBook(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Deletes all books.
        /// </summary>
        /// <returns>The http response message.</returns>
        [Route("delete/all")]
        public HttpResponseMessage DeleteAllBooks()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
