using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KtabiTest.Model;
using KtabiTest.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KtabiTest.Pages
{
    public class OffersModel : PageModel
    {
        private readonly KitabiContext context;

        public IQueryable<Book> Books { get; set; }

        [BindProperty(SupportsGet =true)]
        public int MyProperty { get; set; }



        public OfferManger offer;
        public OffersModel(KitabiContext context)
        {
            this.context = context;
            offer = new OfferManger(context);
        }
        public void OnGet()
        {

            Books = offer.getall();
        }
    }
}
