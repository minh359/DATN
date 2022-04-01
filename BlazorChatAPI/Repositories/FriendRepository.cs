using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Repositories
{
    public class FriendRepository : Repository<Account>
    {
        public FriendRepository(BlazorChatDbContext context) : base(context)
        {
        }
        public List<Account> ListFriend(int id)
        {
            //lấy ra danh sách các group chat
            var ag = context.AccountGroup.Where(n => n.AccountId == id).Select(s=>s.GroupId).ToList();
            //bạn bè là các tài khoản nằm chung group chat với tài khoản có id truyền vào
            List<Account> lst = context.AccountGroup.Where(gc => ag.Contains(gc.GroupId)).Join(context.Account, a => a.AccountId, g => g.AccountId, (a, g) =>g)
                                .Where(w=>w.AccountId!=id).ToList();
                                                          
            return lst;
        }
    }
}
