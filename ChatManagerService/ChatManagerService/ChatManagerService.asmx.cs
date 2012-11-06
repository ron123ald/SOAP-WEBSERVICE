using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ChatManagerService.ServiceImplementation;
using ChatManagerService.ServiceInterface;
using ChatManagerService.ServiceResponse;

namespace ChatManagerService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://ron123ald.somee.com/SOAP-WEBSERVICE/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ChatManagerInterface : System.Web.Services.WebService
    {
        private IChatManagerService _services = default(IChatManagerService);
        public ChatManagerInterface()
        {
            this._services = new ChatManagerSerivce();
        }

        [WebMethod]
        public ChatManagerResponse KeepAlive()
        {
            return this._services.KeepAlive();
        }

        [WebMethod]
        public UserResponse CreateUser(string username, string password, string emailAddress)
        {
            return this._services.CreateUser(username, password, emailAddress);
        }

    }
}
