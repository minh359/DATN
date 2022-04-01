using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Repositories
{
    public class GroupRepository: Repository<GroupChat>
    {
        public GroupRepository(BlazorChatDbContext context) : base(context)
        {

        }
        
    }
}
