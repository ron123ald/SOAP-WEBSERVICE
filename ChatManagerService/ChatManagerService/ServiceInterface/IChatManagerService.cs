using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ChatManagerService.ServiceResponse;

namespace ChatManagerService.ServiceInterface
{
    [ServiceContract]
    public interface IChatManagerService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        ChatManagerResponse KeepAlive();

        [OperationContract]
        [WebInvoke(Method = "POST")]
        UserResponse CreateUser(string username, string password, string emailAddress);
    }
}
