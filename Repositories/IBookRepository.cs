using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DataModels;

namespace WebAPI.Repositories
{
    //this contains all operation to be performed in data base
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int id);

        Task<Book> Create(Book book);

        Task Update(Book book);

        Task Delete(int id);
    }
}
