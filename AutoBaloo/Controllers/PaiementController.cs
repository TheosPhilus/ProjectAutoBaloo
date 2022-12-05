using AutoBaloo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Controllers
{
    public class PaiementController : Controller
    {
        private readonly AppDbContext _context;

        public PaiementController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allPaiements = await _context.Paiements.ToListAsync();
            return View();
        }
    }
}
