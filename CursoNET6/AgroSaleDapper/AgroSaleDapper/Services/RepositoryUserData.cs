using AgroSaleDapper.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AgroSaleDapper.Services
{
    public class RepositoryUserData : IRepositoryUserData
    {
        private readonly string connectionString;
        public RepositoryUserData(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        //Create
        public async Task Create(UserData userData)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>(@"INSERT INTO UserData(Name,LastName,Addres, phone, UserId)
                                                              VALUES(@Name,@LastName, @Addres, @phone, @UserId);
                                                              SELECT SCOPE_IDENTITY();", userData);
            userData.Id = id;
        }

        //list
        public async Task<IEnumerable<UserData>> GetUserData(int UserId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<UserData>(@"SELECT Id, Name,LastName,Addres,phone
                                                           FROM UserData
                                                           WHERE UserId = @UserId", new { UserId });
        }
        //GetIdForUpdate
        public async Task<UserData> GetForId(int id, int userid)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<UserData>(@"SELECT Id, Name,LastName,Addres,phone
                                                                 FROM UserData
                                                                 WHERE Id = @Id AND UserId = @UserId",
                                                                 new { id, userid });
        }

        //update
        public async Task Update(UserData userData)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"UPDATE UserData
                                            SET Name = @Name, LastName = @LastName, Addres = @Addres, phone = @phone
                                            WHERE Id=@Id",userData);
        }

        public async Task Delete(int Id)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE UserData WHERE Id= @Id", new { Id });
        }
        
    }
}
