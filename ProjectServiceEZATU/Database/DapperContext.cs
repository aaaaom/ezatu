//using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
public class DapperContext
{
    private readonly IConfiguration _config;
    private readonly string _connectionString;
    private readonly string _connectionString2;
    private readonly SqlConnection _connection;

    public DapperContext(IConfiguration configuration)
    {
        _config = configuration;
        _connectionString = _config.GetConnectionString("SqlConnection");
        _connectionString2 = _config.GetConnectionString("SqlConnection2");
    }
    public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
        throw new NotImplementedException();
    }

    public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
    {
        using IDbConnection db = new SqlConnection(_config.GetConnectionString(_connectionString));
        return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
    }

    public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
        using IDbConnection db = new SqlConnection(_config.GetConnectionString(_connectionString));
        return db.Query<T>(sp, parms, commandType: commandType).ToList();
    }

    public DbConnection GetDbconnection()
    {
        return new SqlConnection(_connectionString);
    }
    public DbConnection GetDbconnection2()
    {
        return new SqlConnection(_connectionString2);
    }

    public T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
        T result;
        using IDbConnection db = new SqlConnection(_config.GetConnectionString(_connectionString));
        try
        {
            if (db.State == ConnectionState.Closed)
                db.Open();

            using var tran = db.BeginTransaction();
            try
            {
                result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (db.State == ConnectionState.Open)
                db.Close();
        }

        return result;
    }

    public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
    {
        T result;
        using IDbConnection db = new SqlConnection(_config.GetConnectionString(_connectionString));
        try
        {
            if (db.State == ConnectionState.Closed)
                db.Open();

            using var tran = db.BeginTransaction();
            try
            {
                result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (db.State == ConnectionState.Open)
                db.Close();
        }

        return result;
    }
}  
    //public IDbConnection CreateConnection()
    //    => new SqlConnection(_connectionString);
