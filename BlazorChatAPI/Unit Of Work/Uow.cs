
using BlazorChatAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Unit_Of_Work
{
    public class Uow : IDisposable
    {
        private BlazorChatDbContext context = new BlazorChatDbContext();
        private AccountRepository account;
        private Repository<BoxChat> boxChat;
        private Repository<GroupChat> groupChat;
        private Repository<AccountGroup> accGrp;
        private Repository<Message> message;
        private Repository<Reaction> reaction;
        private Repository<StatusInBoxChat> status;
        private Repository<TypeOfGroup> groupType;
        private Repository<TypeOfMessage> messageType;
        private Repository<TypeOfPermission> permissionType;
        private Repository<TypeOfReaction> reactionType;
        private FriendRepository friend;
        public FriendRepository Friend
        {
            get
            {

                if (this.friend == null)
                {
                    this.friend = new FriendRepository(context);
                }
                return friend;
            }
        }

        public Repository<AccountGroup> AccGrp
        {
            get
            {

                if (this.accGrp == null)
                {
                    this.accGrp = new Repository<AccountGroup>(context);
                }
                return accGrp;
            }
        }

        public AccountRepository Account
        {
            get
            {

                if (this.account == null)
                {
                    this.account = new AccountRepository(context);
                }
                return account;
            }
        }
        public Repository<BoxChat> BoxChat
        {
            get
            {

                if (this.boxChat == null)
                {
                    this.boxChat = new Repository<BoxChat>(context);
                }
                return boxChat;
            }
        }
        public Repository<GroupChat> GroupChat
        {
            get
            {

                if (this.groupChat == null)
                {
                    this.groupChat = new Repository<GroupChat>(context);
                }
                return groupChat;
            }
        }
        public Repository<Message> Message
        {
            get
            {

                if (this.message == null)
                {
                    this.message = new Repository<Message>(context);
                }
                return message;
            }
        }
        public Repository<Reaction> Reaction
        {
            get
            {

                if (this.reaction == null)
                {
                    this.reaction = new Repository<Reaction>(context);
                }
                return reaction;
            }
        }
        public Repository<StatusInBoxChat> Status
        {
            get
            {

                if (this.status == null)
                {
                    this.status = new Repository<StatusInBoxChat>(context);
                }
                return status;
            }
        }
        public Repository<TypeOfGroup> GroupType
        {
            get
            {

                if (this.groupType == null)
                {
                    this.groupType = new Repository<TypeOfGroup>(context);
                }
                return groupType;
            }
        }
        public Repository<TypeOfMessage> MessageType
        {
            get
            {

                if (this.messageType == null)
                {
                    this.messageType = new Repository<TypeOfMessage>(context);
                }
                return messageType;
            }
        }
        public Repository<TypeOfPermission> PermissionType
        {
            get
            {

                if (this.permissionType == null)
                {
                    this.permissionType = new Repository<TypeOfPermission>(context);
                }
                return permissionType;
            }
        }
        public Repository<TypeOfReaction> ReactionType
        {
            get
            {

                if (this.reactionType == null)
                {
                    this.reactionType = new Repository<TypeOfReaction>(context);
                }
                return reactionType;
            }
        }
        public void Save()
        {
            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch
                {
                    dbContextTransaction.Rollback();
                }
            }

        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
