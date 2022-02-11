using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KtabiTest.Pages
{
    public class CustomerHomeModel : PageModel
    {
        public int MyProperty { get; set; }
        public string CustomerName{ get; set; }
        public void OnGet()
        {
            CustomerName = "Peter";
        }
    }
}
