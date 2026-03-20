namespace Devices.Infraestructure.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task<T> Update(T entity);
        Task Delete(int id);
    }

}
