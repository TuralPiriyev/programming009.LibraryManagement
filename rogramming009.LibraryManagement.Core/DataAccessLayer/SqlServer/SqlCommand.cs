using System;

namespace programming009.LibraryManagement.Core.DataAccessLayer.SqlServer
{
    internal class SqlCommand
    {
        private string query;
        private SqlConnection connection;

        public SqlCommand(string query, SqlConnection connection)
        {
            this.query = query;
            this.connection = connection;
        }

        public object Parameters { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        internal int ExecuteScalar()
        {
            throw new NotImplementedException();
        }
    }
}