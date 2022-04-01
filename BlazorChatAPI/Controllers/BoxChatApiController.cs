using BlazorChatAPI.Unit_Of_Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Controllers
{
    public class BoxChatApiController : ControllerBase
    {
        Uow uow = new Uow();


        [Route("box/")]
        public List<BoxChat> BoxChat()
        {
            return uow.BoxChat.FindAll().ToList();
        }
        [Route("box/add")]
        [HttpPost]
        public string AddBox(string box_name,string img)
        {
            try
            {
                BoxChat box = new BoxChat();
                box.Name = box_name;
                box.Image = (img == "") ? "DefaultImg.jpg" : img;
                uow.BoxChat.Add(box);
                uow.Save();
                return box.BoxId.ToString();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
