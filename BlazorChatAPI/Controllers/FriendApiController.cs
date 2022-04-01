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
    public class FriendApiController : ControllerBase
    {
        Uow uow = new Uow();
        [Route("friend/")]
        public List<Account> Friend(int id)
        {
            return uow.Friend.ListFriend(id).ToList();
        }

    }
}
