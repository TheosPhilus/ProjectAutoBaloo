using Microsoft.AspNetCore.Mvc;
using AutoBaloo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoBaloo.Controllers
{
    public class VehiculeController : Controller
    {
        private readonly AppDbContext _context;

        public VehiculeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult >Index()
        {
            var allVehicules = await _context.Vehicules.ToListAsync();
            return View(allVehicules);
        }

        
    }
}
