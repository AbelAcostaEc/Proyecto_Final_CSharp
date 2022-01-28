using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class BiometricosController : Controller
    {
        private readonly PeriodoPruebaDB db;

        public BiometricosController(PeriodoPruebaDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Biometrico> listaBiometricos = db.Biometricos;
            return View(listaBiometricos);
        }
      
        public IActionResult Create()
        {
            return View();
        }

    }
}
