using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios
{
    public class RepositorioTiposCuentas : IRepositorioTiposCuentas
    {
        private readonly string connectionString;
        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        //crear
        public async Task Crear(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>($@"INSERT INTO TiposCuentas (Nombre, UsuarioId, Orden) 
                                                    Values(@Nombre, @UsuarioId,0);
                                                    SELECT SCOPE_IDENTITY();", tipoCuenta);
            tipoCuenta.Id = id;
        }

        //validacion
        public async Task<bool> Existe(string nombre, int usuarioId)
        {
            using var connection = new SqlConnection(connectionString);
            //traer el primer valor cero "devurlve cero si no hay nada int"
            var existe = await connection.QueryFirstOrDefaultAsync<int>(@"SELECT 1 
                                                                         FROM TiposCuentas
                                                                         WHERE Nombre = @Nombre AND UsuarioId = @UsuarioId;",
                                                                         new { nombre, usuarioId });
            return existe == 1;
        }

        //listar
        public async Task<IEnumerable<TipoCuenta>> GetTipoCuenta(int usuarioId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<TipoCuenta>(@"SELECT Id, Nombre, Orden 
                                                             FROM TiposCuentas
                                                             WHERE UsuarioId = @UsuarioId
                                                             ORDER BY Orden", new { usuarioId });
        }

        //update
        public async Task Actualizar(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"UPDATE TiposCuentas
                                            set Nombre = @Nombre
                                            Where Id= @Id", tipoCuenta);
        }

        //get idCuenta
        public async Task<TipoCuenta> GetPorId(int id, int usuarioid)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<TipoCuenta>(@"SELECT  Id, Nombre, Orden
                                                                  FROM TiposCuentas
                                                                  WHERE Id = @Id AND UsuarioId = @UsuarioId",
                                                                  new { id, usuarioid });
        }

        //Delete
        public async Task Borrar(int Id)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE TiposCuentas WHERE Id= @Id", new { Id });
        }

        //Campo Ordenes
        public async Task Ordenar(IEnumerable<TipoCuenta> tipoCuentasOrdenados)
        {
            var query = "UPDATE TiposCuentas SET Orden = @Orden where Id=@Id;";
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(query, tipoCuentasOrdenados);
        }

    }
}
