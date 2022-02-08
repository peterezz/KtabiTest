using KtabiTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtabiTest.Repository
{
    public class OfferManger
    {
        private readonly KitabiContext dbContext;
        private BaseRepo<Book> _Rebo;
        public OfferManger(KitabiContext DbContext)
        {
    
        dbContext = DbContext;
            _Rebo = new BaseRepo<Book>(DbContext);
        }

        public IQueryable<Book> getall()
        {
            var data = _Rebo.GetMany(book=>book.Offer!=null && book.IsActive==true&&book.IsApproved==true,  Book=>Book.Author, Book => Book.User);
            return data;
        }
    }
}
