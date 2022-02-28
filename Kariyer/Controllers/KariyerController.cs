using Kariyer.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Kariyer.Models;

namespace Kariyer.Controllers
{
    public class KariyerController : Controller
    {
        private readonly KariyerDbContext _context;

        private readonly IWebHostEnvironment webHost;

        public KariyerController(KariyerDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            //_webHost =webHost;
        }

        public IActionResult Index()
        {
            List<BasvuruSahibi> applicants;
            applicants = _context.BasvuruSahibis.ToList();
            return View(applicants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            BasvuruSahibi basvuruSahibi = new BasvuruSahibi();
            return View(basvuruSahibi);
        }

        [HttpPost]
        public IActionResult Create(BasvuruSahibi basvuruSahibi)
        {
            _context.Add(basvuruSahibi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
