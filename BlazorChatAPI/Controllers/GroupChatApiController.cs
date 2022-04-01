using BlazorChatAPI.Data;
using BlazorChatAPI.Unit_Of_Work;
using BlazorChatShared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorChatAPI.Controllers
{
    [ApiController]
    public class GroupChatApiController : ControllerBase
    {
        Uow uow = new Uow();
        [HttpGet]
        [Route("group/")]
        public List<GroupChat> GetListGroup()
        {
            return uow.GroupChat.FindAll().ToList();
        }
        [HttpPost]
        [Route("group/add")]
        public string AddGroup([FromBody] AddGroupModel model)
        {
            try
            {
                //thêm box chat tương ứng
                BoxChatApiController boxChatApi = new BoxChatApiController();
                int box_id = int.Parse(boxChatApi.AddBox(model.grp_name, ""));

                //thêm group chat mới
                GroupChat group = new GroupChat();
                group.GroupName = model.grp_name;
                group.GroupType = model.grp_type;
                group.BoxId = box_id;
                uow.GroupChat.Add(group);
                int grp_id = group.GroupId;

                //thêm List Account-Group tương ứng với số thành viên trong nhóm
                AccountGroupApiController accountGroupApi = new AccountGroupApiController();
                List<int> lst_accgrp = new List<int>();
                foreach (int id in model.lst_acc)
                {
                    lst_accgrp.Add(int.Parse(accountGroupApi.AddAccgrp(id, grp_id)));
                }

                //thêm List StatusInBoxChat tương ứng với số Account-Group được tạo ra
                StatusInBoxChatApiController statusApi = new StatusInBoxChatApiController();
                for (int i = 0; i < lst_accgrp.Count; i++)
                {
                    if (i == 1)
                    {
                        statusApi.AddSIBC(lst_accgrp[i], 1, true);
                    }
                    else
                    {
                        statusApi.AddSIBC(lst_accgrp[i], 2, false);
                    }
                }
                boxChatApi = null;
                accountGroupApi = null;
                statusApi = null;
                uow.Save();
                return grp_id.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        } 
    }
}
