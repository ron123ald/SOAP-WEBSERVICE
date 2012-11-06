using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatManagerService.ChatEntity;
using ChatManagerService.ServiceInterface;

namespace ChatManagerService.CollectionEntity
{
    public class ChatManagerRepository : IChatManagerRepository, IDisposable
    {
        private bool _disposed = false;
        private ChatEntityContext _context = default(ChatEntityContext);
        public ChatManagerRepository(ChatEntityContext context)
        {
            this._context = context;
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {

                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public int InsertEntity(tbl_User user)
        {
            return this._context.Add(user);
        }

        public tbl_User GetEntity(string username, string emailAddress)
        {
            return this._context.GetEntity(username, emailAddress);
        }
    }
}