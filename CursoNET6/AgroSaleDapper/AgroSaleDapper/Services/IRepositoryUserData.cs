using AgroSaleDapper.Models;

namespace AgroSaleDapper.Services
{
    public interface IRepositoryUserData
    {
        Task Create(UserData userData);
        Task Delete(int Id);
        Task<UserData> GetForId(int id, int userid);
        Task<IEnumerable<UserData>> GetUserData(int UserId);
        Task Update(UserData userData);
    }
}
