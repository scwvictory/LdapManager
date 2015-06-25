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
    [DirectorySchemaEx(ObjectClass = "inetOrgPerson")]
    public class LdapUserPassword
    {
        [DistinguishedName]
        public string DistinguishedName { get; set; }

        [DirectoryAttribute("uid", ReadOnly = true)]
        [Required, StringLength(200)]
        public string Id { get; set; }

        [DirectoryAttribute("userPassword")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}