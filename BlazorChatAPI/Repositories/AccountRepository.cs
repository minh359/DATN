using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Repositories
{
    public class AccountRepository : Repository<Account>
    {
        public AccountRepository(BlazorChatDbContext context) : base(context)
        {
        }
        public List<Account> GetAccountsInGroup(int grp_id)
        {
            List<int?> lst_accgrp = context.AccountGroup.Where(ag => ag.GroupId==grp_id).Select(s=>s.AccountId).ToList() ;
            List<Account> result  = new List<Account>();
            foreach(var item in lst_accgrp)
            {
                Account acc = new Account();
                acc = context.Account.Where(w => w.AccountId == item).FirstOrDefault();
                if(acc!=null)
                {
                    result.Add(acc);
                }
            }
            return result;
        }
    }
}
