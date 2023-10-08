using System;

namespace programming009.LibraryManagement.Core.DataAccessLayer.SqlServer
{
    internal class SqlConnection
    {
        private string connectionString;

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}