using IMS.Domain.Entities.Dependencies;
using IMS.Infrastructure.Interfaces;

namespace IMS.Infrastructure.Repository
{
    public class PersistLensTypes : IRepository<GlassesLensType>
    {
        public Task<IEnumerable<GlassesLensType>> GetAllTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GlassesLensType> GetTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertType(GlassesLensType type)
        {
            throw new NotImplementedException();
        }

        public void RemoveType(GlassesLensType type)
        {
            throw new NotImplementedException();
        }

        public Task UpdateType(GlassesLensType type)
        {
            throw new NotImplementedException();
        }
    }
}
