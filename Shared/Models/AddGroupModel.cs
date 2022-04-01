using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChatShared.ViewModels
{

    public class AddGroupModel
    {

        public string grp_name { get; set; }
        public int grp_type { get; set; }
        public List<int> lst_acc { get; set; }


    }
}
