using System.Data.Entity;

namespace Axmor_TestIssue.SqlServer
{
    public class DbContextFactory : IDbContextFactory
    {
        public DbContext GetContext()
        {
            return new Db();
        }
    }
}
