using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using LdapManagerApi.Models;

namespace LdapManagerApi.Migrations
{
    public class LdapManagerDbInitializer : CreateDatabaseIfNotExists<LdapManagerDbContext>
    {
        protected override void Seed(LdapManagerApi.Models.LdapManagerDbContext context)
        {
            //administratorをAdministratorsロールに追加
            var roles = new List<LdapUserRole> {
                new LdapUserRole
                {
                    Name = "Administrators",
                    Members = new List<LdapUserRoleMember> {
                        new LdapUserRoleMember
                        {
                            LdapId = "administrator",
                        }
                    },
                },
            };
            context.LdapUserRoles.AddRange(roles);
            context.SaveChanges();
        }
    }
}