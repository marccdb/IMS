namespace IMS.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllTypesAsync();

        Task<T> GetTypeById(int id);

        Task InsertType(T type);

        Task UpdateType(T type);

        void RemoveType(T type);
    }
}
