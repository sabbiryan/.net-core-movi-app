using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public string Index()
        {
            return "This is my default action...";
        }


        public string Welcome(string name, int numTimes = 1)
        {
            return
                HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}. Current Date Time is : {DateTime.Now}");
        }


        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
