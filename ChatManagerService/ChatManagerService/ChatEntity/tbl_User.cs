using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ChatManagerService.ChatEntity
{
    public class tbl_User : TEntity
    {
        public string username { get; set; }
        public string password { get; set; }
        public string emailAddress { get; set; }
        public string salt { get; set; }
        public tbl_User() { }

        public tbl_User(string username, string password, string emailAddress)
        {
            this.username = username;
            this.password = password;
            this.emailAddress = emailAddress;
            this.salt = Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}