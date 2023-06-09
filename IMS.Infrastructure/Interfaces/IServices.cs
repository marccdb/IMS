namespace IMS.Infrastructure.Interfaces
{
    public interface IServices
    {
        Task Add();
        Task Get();
        Task GetById();
        Task Update();
        Task Remove();
    }
}
