using LibraryCorner.Models;
using LibraryCorner.Models.RequestModels;
using LibraryCorner.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LibraryCorner.BorrowedMenu
{
    public class ReservedModel
    {
        private readonly IRepository<Author, RequestAuthor> _authorRepository;
        private readonly IRepository<Book, RequestBook> _bookRepository;
        private readonly IRepository<Library, RequestLibrary> _libraryRepository;
        public ReservedModel(IRepository<Author, RequestAuthor> authorRepository,
            IRepository<Book, RequestBook> bookRepository,
            IRepository<Library, RequestLibrary> libraryRepository)
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
            _libraryRepository = libraryRepository;
        }

        public void A(LibraryModel model)
        {
           
            var author = _authorRepository.Find(new RequestAuthor(model.Name, model.Surname));
            var book = _bookRepository.Find(new RequestBook(model.Title, model.Year));
            var library = _libraryRepository.Find(new RequestLibrary(model.Name));

            if (author != null && book != null && library != null)
            {
                if (book.Quanitity != 0)
                {
                        book.IsReserved = true;
                }
                else { throw new ArgumentException("Book is finished."); }
            }
            else { throw new ArgumentException("Book is not found."); }
        }
    

    }
}


