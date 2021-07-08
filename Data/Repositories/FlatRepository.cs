using Core.Interfaces;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class FlatRepository : RepositoryBase<Flat>, IFlatRepository
    {

        public FlatRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<ICollection<Flat>> GetAllWithUsers()
        {
            return await _context.Flats.Include(x => x.User).ToListAsync();
        }

        public async Task<Flat> GetWithUser(int flatId)
        {
            return await _context.Flats.Include(x => x.User).Where(x => x.Id == flatId).FirstOrDefaultAsync();
        }
    }
}
