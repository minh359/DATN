using BlazorChatAPI.Unit_Of_Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Controllers
{
    [ApiController]
    public class AccountApiController : ControllerBase
    {
        Uow uow = new Uow();
        [Route("acc/")]
        public List<Account> Account()
        {
            return uow.Account.FindAll().ToList();
        }
        [Route("acc/grp")]
        public List<Account> AccInGroup(int grp_id)
        {
            return uow.Account.GetAccountsInGroup(grp_id);
        }
    }
}
