using IMS.Domain.Entities.Dependencies;
using IMS.Infrastructure.Interfaces;

namespace IMS.Infrastructure.Repository
{
    public class PersistSizes : IRepository<GlassesSize>
    {
        public Task<IEnumerable<GlassesSize>> GetAllTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GlassesSize> GetTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertType(GlassesSize type)
        {
            throw new NotImplementedException();
        }

        public void RemoveType(GlassesSize type)
        {
            throw new NotImplementedException();
        }

        public Task UpdateType(GlassesSize type)
        {
            throw new NotImplementedException();
        }
    }
}
