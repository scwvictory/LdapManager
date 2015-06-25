using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LdapManagerApi.ViewModels.LdapUser
{
    public class SetPasswordModel
    {
        /// <summary>
        /// ユーザーID(uid)
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// パスワード(プレーンテキスト)
        /// </summary>
        public string Password { get; set; }
    }

    public class ChangePasswordModel
    {
        /// <summary>
        /// ユーザーID(uid)
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 旧パスワード
        /// </summary>
        public string OldPassword { get; set; }
        /// <summary>
        /// 新パスワード
        /// </summary>
        public string NewPassword { get; set; }
    }

    public class IsInRoleModel
    {
        /// <summary>
        /// LDAPユーザ
        /// </summary>
        public LdapManagerApi.Models.LdapUser user { get; set; }
        /// <summary>
        /// ロール名
        /// </summary>
        public string role { get; set; }
    }

    public class AddToRoleModel
    {
        /// <summary>
        /// LDAPユーザ
        /// </summary>
        public LdapManagerApi.Models.LdapUser user { get; set; }
        /// <summary>
        /// ロール名
        /// </summary>
        public string role { get; set; }
    }

    public class RemoveFromRoleModel
    {
        /// <summary>
        /// LDAPユーザ
        /// </summary>
        public LdapManagerApi.Models.LdapUser user { get; set; }
        /// <summary>
        /// ロール名
        /// </summary>
        public string role { get; set; }
    }
}