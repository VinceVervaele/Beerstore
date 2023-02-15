
using BeerShop.Repositories;
using BeerStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beershop.Services
{
    public class BeerService
    {
        private BeerDAO beerDAO;
        public BeerService()
        {
            // later via DI
            beerDAO = new BeerDAO();
        }

        public async Task<IEnumerable<Beer>?> GetAllAsync()
        {
            return await beerDAO.GetAllAsync();
        }
       

        public async Task<Beer?> GetAsync(int id)
        {
            return await beerDAO.GetAsync(id);
        }


        public async Task AddAsync(Beer entity)
        {
            await beerDAO.AddAsync(entity);
        }
        public async Task EditAsync(Beer entity)
        {
            await beerDAO.EditAsync(entity);
        }





















    }
}
