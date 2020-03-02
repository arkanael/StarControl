using Dapper;
using starcontrol.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarControl.Infra.Data.Repository
{
    public class ClienteRepository
    {
        private readonly string connectionString;

        public ClienteRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        }

        public void Insert(Cliente cliente)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO CLIENTE(NOME, EMAIL) VALUES(@Nome, @Email)";
                sqlConnection.Execute(query, cliente);
            }
        }

        public void Update(Cliente cliente)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var query = "UPDATE CLIENTE SET Nome = @Nome, Email = @Email";
                sqlConnection.Execute(query, cliente);
            }
        }

        public void Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM CLIENTE WHERE Id = @Id";
                sqlConnection.Execute(query, new { Id = @id});
            }
        }

        public List<Cliente> Find()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM CLIENTE";
                return sqlConnection.Query<Cliente>(query).ToList();
            }
        }
        public Cliente Find(int id)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM CLIENTE WHERE Id = @id";
                return sqlConnection.QuerySingleOrDefault<Cliente>(query, new { Id = @id });
            }
        }
    }
}
