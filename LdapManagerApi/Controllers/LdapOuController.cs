﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Threading.Tasks;
using LdapManagerApi.Ldap;
using LdapManagerApi.Models;
using LdapManagerApi.Utilities;

namespace LdapManagerApi.Controllers
{
    public class LdapOuController : ApiController
    {
        [Authorize]
        [HttpPost]
        [ActionName("GetList")]
        public async Task<HttpResponseMessage> GetList()
        {
            try
            {
                //OUリストを取得
                var results = await new LdapOuStore().FindAsync();
                //ユーザー情報を返す
                return Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
