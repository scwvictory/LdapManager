using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace LdapManagerApi.Models
{
    public class LdapManagerDbContext : DbContext
    {
        public LdapManagerDbContext()
            : base("name=LdapManagerDbConnection")
        {
        }

        public virtual DbSet<LdapUserRole> LdapUserRoles { get; set; }
        public virtual DbSet<LdapUserRoleMember> LdapUserRoleMembers { get; set; }
    }
}