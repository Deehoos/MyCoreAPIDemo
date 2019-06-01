using MyCoreAPIDemo.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPIDemo.Repository.Implementation
{
    public class LibraryRepository : ILibraryRepository<Author>
    {
        readonly LibraryContext _libraryContext;

        public LibraryRepository(LibraryContext context)
        {
            _libraryContext = context;
        }

        public IEnumerable<Author> GetAllAuthor()
        {
            return _libraryContext.Authors.ToList();
        }

        public void AddAuthor()
        {
            //_libraryContext.Authors.Add
            //return _libraryContext.Authors.ToList();
        }
    }
}
