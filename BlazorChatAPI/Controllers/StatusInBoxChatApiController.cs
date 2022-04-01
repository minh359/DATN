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
    public class StatusInBoxChatApiController : ControllerBase
    {
        Uow uow = new Uow();
        [Route("stt/add")]
        public string AddSIBC(int accgrp_id, int permission_id,bool isCreator)
        {
            try
            {
                StatusInBoxChat stt = new StatusInBoxChat();
                stt.AccountGroupId = accgrp_id;
                stt.TypeOfPermissionId = permission_id;
                stt.IsCreator = (isCreator) ? isCreator : false;
                stt.CurrentStatus = "Offline";
                uow.Status.Add(stt);
                uow.Save();
                return stt.StatusId.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
