using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using LinqToLdap.Mapping;
using LdapManagerApi.Attributes;
using LdapManagerApi.Utilities;

namespace LdapManagerApi.Models
{
    [DirectorySchemaEx(ObjectClass = "organizationalUnit")]
    public class LdapOu
    {
        [DirectoryAttribute("ou", ReadOnly = true)]
        [Required, StringLength(200)]
        public string Name { get; set; }

        [DistinguishedName]
        public string DistinguishedName { get; set; }

        public void SetDistinguishedName()
        {
            DistinguishedName = string.Format("ou={0},{1}", Name, LdapConfig.NamingContext);
        }
    }
}