

using BeerShop.Repositories;
using BeerStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beershop.Services
{
    public class BreweryService
    {
        private BreweryDAO breweryDAO;
        public BreweryService()
        {
            breweryDAO = new BreweryDAO();
        }

        public async Task<IEnumerable<Brewery>> GetAllAsync()
        {
            return await breweryDAO.GetAllAsync();
        }
    }
}
