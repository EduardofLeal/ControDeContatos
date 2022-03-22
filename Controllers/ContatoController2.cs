using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControDeContatos.Controllers
{
    public class ContatoController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
