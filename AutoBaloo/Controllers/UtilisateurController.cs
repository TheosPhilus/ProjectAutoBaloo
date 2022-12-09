using AutoBaloo.Data;
using AutoBaloo.Data.Service;
using AutoBaloo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Controllers
{
   /* public class UtilisateurController : Controller
    {
        private readonly IUtilisateurService  _UsersRepository;

        public UtilisateurController(IUtilisateurService service)
        {
            _UsersRepository = service;
        }
        public async Task<IActionResult> Index()
        {
            var allUtilisateurs = await _UsersRepository.GetAllAsync();
            return View();
        }



        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("NomUtilisateur,EmailUtilisateur,Adresse")] Utilisateur users)
        {
            if (!ModelState.IsValid)
            {
                return View(users);
            }
            await _UsersRepository.AddAsync(users);
            return RedirectToAction(nameof(Index));
        }

        //Get: Users/Details/1
       
        public async Task<IActionResult> Details(int id)
        {
            var usersDetails = await _UsersRepository.GetByIdAsync(id);

            if (usersDetails == null) return View("NotFound");
            return View(usersDetails);
        }

        //Get: Users/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var usersDetails = await _UsersRepository.GetByIdAsync(id);
            if (usersDetails == null) return View("NotFound");
            return View(usersDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("NomUtilisateur,EmailUtilisateur,Adresse")] Utilisateur users)
        {
            if (!ModelState.IsValid)
            {
                return View(users);
            }
            await _UsersRepository.UpdateAsync(id, users);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var usersDetails = await _UsersRepository.GetByIdAsync(id);
            if (usersDetails == null) return View("NotFound");
            return View(usersDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersDetails = await _UsersRepository.GetByIdAsync(id);
            if (usersDetails == null) return View("NotFound");

            await _UsersRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }*/
}

