using AutoBaloo.Data;
using AutoBaloo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allReservations = await _context.Reservations.ToListAsync();
            return View(allReservations);
        }


        //Get: Reservation/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("DateDebut,Duree,DateFin,TypeReservation")] Reservation Reservation)
        {
            if (!ModelState.IsValid)
            {
                return View(Reservation);
            }
            await _context.AddAsync(Reservation);
            return RedirectToAction(nameof(Index));
        }
    }
}
