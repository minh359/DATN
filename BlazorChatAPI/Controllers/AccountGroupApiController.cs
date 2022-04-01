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
    public class AccountGroupApiController : ControllerBase
    {
        Uow uow = new Uow();
        [Route("accgrp/add")]
        public string AddAccgrp(int acc_id,int grp_id)
        {
            try
            {
                AccountGroup accgrp = new AccountGroup();
                accgrp.AccountId = acc_id;
                accgrp.GroupId = grp_id;
                uow.AccGrp.Add(accgrp);
                uow.Save();
                return accgrp.AccountGroupId.ToString();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
