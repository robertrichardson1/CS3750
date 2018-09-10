using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace McvMusicStore.Controllers
{
    public class Welcome_old : Controller
    {
        public string Index()
        {
            return "This is my default...";
        }

        public string WelcomeClass(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");

        }
        // GET: /<controller>/
       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}
