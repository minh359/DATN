using BlazorChatAPI.Unit_Of_Work;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BlazorChatAPI.Controllers
{
   
    [ApiController]
    public class BlazorApiController : ControllerBase
    {
        [Route("index/")]
        public string Index()
        {
            return "Blazor Api Server ! ! !";
        }
        Uow uow = new Uow();

    }
}
