using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatManagerService.ChatEntity;

namespace ChatManagerService.CollectionEntity
{
    public class ChatEntityContext
    {
        private List<tbl_User> _collection = default(List<tbl_User>);
        private static ChatEntityContext _instance = default(ChatEntityContext);
        private ChatEntityContext()
        {
            this._collection = new List<tbl_User>();
        }
        public static ChatEntityContext GetInstanceContext()
        {
            return _instance ?? (_instance = (new ChatEntityContext()));
        }

        public int Add(tbl_User entity)
        {
            if (!_collection.Contains(entity))
            {
                this._collection.Add(entity);
                return this._collection.Count;
            }
            return 0;
        }

        public tbl_User GetEntity(string username, string emailAddress)
        {
            return this._collection.SingleOrDefault(
                e => string.Compare(e.username, username, true) == 0 &&
                     string.Compare(e.emailAddress, emailAddress, true) == 0
                );
        }

        public IQueryable<tbl_User> GetEntities()
        {
            return (IQueryable<tbl_User>)this._collection;
        }
    }
}