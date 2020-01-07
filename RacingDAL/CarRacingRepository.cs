using RacingDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDAL
{
    public class CarRacingRepository : GenericRacingRepository<RacingCar>
    {
        public CarRacingRepository(DbContext context) : base(context)
        {

        }
        public async override Task<RacingCar> FindByIdAsync(int id)
        {
            var itemBuId = await _dbSet.Include(x => x.Engine).Include(x=>x.Brake).SingleOrDefaultAsync<RacingCar>(e => e.Id == id);
            return itemBuId;
        }
    }
}
