using System.Data.Entity;

namespace Axmor_TestIssue.SqlServer
{
    public interface IDbContextFactory
    {
        DbContext GetContext(); 
    }
}