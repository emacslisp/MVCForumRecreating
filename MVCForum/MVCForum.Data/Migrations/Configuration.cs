using MVCForum.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MVCForumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MVCForumContext context)
        {

        }
    }
}
