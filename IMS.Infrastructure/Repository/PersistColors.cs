using IMS.Domain.Entities.Dependencies;
using IMS.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure.Repository
{
    public class PersistColors : IRepository<GlassesColor>
    {
        public Task<IEnumerable<GlassesColor>> GetAllTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GlassesColor> GetTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertType(GlassesColor type)
        {
            throw new NotImplementedException();
        }

        public void RemoveType(GlassesColor type)
        {
            throw new NotImplementedException();
        }

        public Task UpdateType(GlassesColor type)
        {
            throw new NotImplementedException();
        }
    }
}
