namespace LdapManagerApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using System.Collections.Generic;
    using LdapManagerApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LdapManagerApi.Models.LdapManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LdapManagerApi.Models.LdapManagerDbContext context)
        {
            var roles = new List<LdapUserRole> {
                new LdapUserRole
                {
                    Name = "Administrator",
                },
            };
            context.LdapUserRoles.AddRange(roles);
            context.SaveChanges();
        }
    }
}
