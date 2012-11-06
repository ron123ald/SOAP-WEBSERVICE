using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatManagerService.ChatEntity;
using ChatManagerService.CollectionEntity;
using ChatManagerService.Helper;
using ChatManagerService.ServiceInterface;
using ChatManagerService.ServiceResponse;

namespace ChatManagerService.ServiceImplementation
{
    public class ChatManagerSerivce : IChatManagerService
    {
        public ChatManagerResponse KeepAlive()
        {
            return new ChatManagerResponse
            {
                Message = "OK", Response = true
            };
        }

        public UserResponse CreateUser(string username, string password, string emailAddress)
        {
            UserResponse response = new UserResponse() { Response = ResponseState.Ok.ToString() };
            using (IChatManagerRepository repo = new ChatManagerRepository(ChatEntityContext.GetInstanceContext()))
            {
                try
                {
                    tbl_User user = repo.GetEntity(username, emailAddress);
                    if (user == null)
                    {
                        int resultUserID = 0;
                        user = new tbl_User(username, password, emailAddress);
                        user.password = ServiceUtils.EncryptPassword(user.password, user.salt);
                        if ((resultUserID = repo.InsertEntity(user)) != 0)
                        {
                            response = new UserResponse(resultUserID, user)
                            {
                                Response = ResponseState.Ok.ToString()
                            };
                        }
                    }
                    else
                        throw new ArgumentException("Username and email Exists!");
                }
                catch (Exception ex)
                {
                    response.Message = ex.Message;
                    response.Response = ResponseState.NotOk.ToString();
                }
            }
            return response;
        }
    }
}