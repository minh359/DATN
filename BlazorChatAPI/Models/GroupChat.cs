﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorChatAPI
{
    public partial class GroupChat
    {
        public GroupChat()
        {
            AccountGroup = new HashSet<AccountGroup>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int BoxId { get; set; }
        public int GroupType { get; set; }

        public virtual BoxChat Box { get; set; }
        public virtual TypeOfGroup GroupTypeNavigation { get; set; }
        public virtual ICollection<AccountGroup> AccountGroup { get; set; }
    }
}