
using BeerStore.Models.Data;
using BeerStore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerShop.Repositories
{
    public class VarietyDAO
    {
        private readonly BeerDbContext _db;  // Namespace using BierSQL.Domein.Entities; toevoegen bovenaan

        public VarietyDAO()
        {
            _db = new BeerDbContext();
        }
        public async Task<IEnumerable<Variety>> GetAllAsync()
        {
            try
            {
                return await _db.Varieties.ToListAsync(); // volgende Namespaces toevoegen bovenaan using System.Linq; using Microsoft.EntityFrameworkCore;
            }
            catch (Exception ex)
            { throw; }
        }
    }
}
