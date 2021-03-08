using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Busines
{
    public interface IBookBusiness
    {

        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Person Update(Book book);
        void Delete(long id);

    }
}
