using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ChatManagerService.ChatEntity;

namespace ChatManagerService.ServiceResponse
{
    [DataContract]
    public class UserResponse : CommonAttribute
    {
        [DataMember]
        public int userID { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string emailAddress { get; set; }

        public UserResponse() { }

        public UserResponse(int userID, string username, string password, string emailAddress) 
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.emailAddress = emailAddress;
        }

        public UserResponse(int userID, tbl_User user)
        {
            this.userID = userID;
            this.username = user.username;
            this.password = user.password;
            this.emailAddress = user.emailAddress;
        }
    }
}