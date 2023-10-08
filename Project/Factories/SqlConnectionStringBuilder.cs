namespace programming009.LibraryManagement.Factories
{
    internal class SqlConnectionStringBuilder
    {
        public SqlConnectionStringBuilder()
        {
        }

        public string InitialCatalog { get; internal set; }
        public string DataSource { get; internal set; }
        public bool IntegratedSecurity { get; internal set; }
        public bool TrustServerCertificate { get; internal set; }
        public string UserID { get; internal set; }
        public string Password { get; internal set; }
    }
}