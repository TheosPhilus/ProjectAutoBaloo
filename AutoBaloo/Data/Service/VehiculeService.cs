using AutoBaloo.Data.Base;
using AutoBaloo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Data.Service
{
    public class VehiculeService :  IVehiculeService
    {

      
        
         private readonly AppDbContext _context;

          public VehiculeService(AppDbContext context)
          {
              _context = context;
          }

          public async Task AddAsync(Vehicule vehicule)
          {
              await _context.Vehicules.AddAsync (vehicule);
              await _context.SaveChangesAsync();
          }

          public async Task DeleteAsync(int Id)
          {
              var Result = await _context.Vehicules.FirstOrDefaultAsync(n => n.Id == Id);
               _context.Vehicules.Remove(Result);
              await _context.SaveChangesAsync();
          }

          public async Task<IEnumerable<Vehicule>> GetAllAsync()
          {
              var result =await _context.Vehicules.ToListAsync();
              return result; 
          }

          public async  Task<Vehicule> GetByIdAsync (int id)
          {
              var Result = await _context.Vehicules.FirstOrDefaultAsync(n => n.Id == id);
              return Result;
          }





          public async Task<Vehicule> UpdateAsync(Vehicule vehicule)
          {
               _context.Update(vehicule);
              await _context.SaveChangesAsync();
              return vehicule;
          }
    }
}
