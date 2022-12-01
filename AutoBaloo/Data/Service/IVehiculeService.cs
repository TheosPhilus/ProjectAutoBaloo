using AutoBaloo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Data.Service
{
    public interface IVehiculeService
    {

        Task<IEnumerable<Vehicule>> GetAllAsync();

        Task<Vehicule> GetByIdAsync(int id);


        Task AddAsync(Vehicule vehicule);
        //Vehicule update(int id, Vehicule vehicule);
        void Delete(int id);
        Task <Vehicule> Update(Vehicule vehicule);
    }
}
