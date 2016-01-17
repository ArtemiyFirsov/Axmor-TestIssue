using Axmor_TestIssue.Core.Models;

namespace Axmor_TestIssue.SqlServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Axmor_TestIssue.SqlServer.Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Axmor_TestIssue.SqlServer.Db context)
        {
            if (!context.Items.Any())
            {
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
                context.Items.Add(new Item()
                {
                    Title = "Oh My God!",
                    Text = "Hello!)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    IsDeleted = false
                });
            }
        }
    }
}
