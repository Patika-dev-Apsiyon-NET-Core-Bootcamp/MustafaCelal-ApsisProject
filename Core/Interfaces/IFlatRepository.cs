using Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFlatRepository : IRepository<Flat>
    {
        Task<ICollection<Flat>> GetAllWithUsers();
        Task<Flat> GetWithUser(int apartmentid);
    }
}
