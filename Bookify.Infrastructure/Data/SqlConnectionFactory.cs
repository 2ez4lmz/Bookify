using System.Data;
using Bookify.Application.Abstractions.Data;
using Npgsql;

namespace Bookify.Infrastructure.Data;

public class SqlConnectionFactory : ISqlConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        var connecion = new NpgsqlConnection(_connectionString);
        connecion.Open();

        return connecion;
    }
}