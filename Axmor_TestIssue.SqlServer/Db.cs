using System.Collections.Generic;
using System.Data.Entity;
using Axmor_TestIssue.Core.Models;
using Axmor_TestIssue.SqlServer.Migrations;

namespace Axmor_TestIssue.SqlServer
{
    public class Db : DbContext
    {
        public Db()
            : base("DataContext")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<Db, Configuration>());
        }

        public DbSet<Item> Items { get; set; }
    }
}


