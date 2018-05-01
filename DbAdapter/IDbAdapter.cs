using System;
using System.Collections.Generic;
using System.Data;

namespace DbAccess.DbAdapter
{
    public interface IDbAdapter
    {
        IDbCommand Cmd { get; }
        IDbConnection Conn { get; }

        int ExecuteQuery(string storedProcedure, IDataParameter[] parameters, Action<IDataParameter[]> returnParameters = null);
        T ExecuteScalar<T>(string storedProcedure, IDataParameter[] parameters);
        List<T> LoadObject<T>(string storedProcedure, IDbDataParameter[] parameters) where T : class;
    }
}