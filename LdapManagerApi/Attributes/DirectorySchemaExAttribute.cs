﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using LinqToLdap.Mapping;
using LdapManagerApi.Utilities;

namespace LdapManagerApi.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DirectorySchemaExAttribute : DirectorySchemaAttribute
    {
        public DirectorySchemaExAttribute()
            : base(LdapConfig.NamingContext)
        {
        }
    }
}