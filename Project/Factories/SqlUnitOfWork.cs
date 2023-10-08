namespace programming009.LibraryManagement.Factories
{
    internal class SqlUnitOfWork : IUnitOfWork
    {
        private string? connectionString;

        public SqlUnitOfWork(string? connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}