﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorChatAPI
{
    public partial class TypeOfGroup
    {
        public TypeOfGroup()
        {
            GroupChat = new HashSet<GroupChat>();
        }

        public int TypeOfGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GroupChat> GroupChat { get; set; }
    }
}