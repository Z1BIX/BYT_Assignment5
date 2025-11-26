namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            if (type == DatabaseType.Oracle)
            {
                return new OracleDatabase();
            }
            else if (type == DatabaseType.SqlServer)
            {
                return new SqlServerDatabase();
            }
            else
            {
                throw new Exception("Database type is unknown");
            }
        }
    }
}
