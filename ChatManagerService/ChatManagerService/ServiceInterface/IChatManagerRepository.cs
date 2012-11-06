using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatManagerService.ChatEntity;

namespace ChatManagerService.ServiceInterface
{
    public interface IChatManagerRepository : IDisposable
    {
        void Dispose();
        int InsertEntity(tbl_User user);
        tbl_User GetEntity(string username, string emailAddress);
    }
}
