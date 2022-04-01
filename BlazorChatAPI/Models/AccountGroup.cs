﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorChatAPI
{
    public partial class AccountGroup
    {
        public AccountGroup()
        {
            Message = new HashSet<Message>();
            Reaction = new HashSet<Reaction>();
            StatusInBoxChat = new HashSet<StatusInBoxChat>();
        }

        public int AccountGroupId { get; set; }
        public bool? IsMember { get; set; }
        public int? AccountId { get; set; }
        public int? GroupId { get; set; }

        public virtual Account Account { get; set; }
        public virtual GroupChat Group { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<Reaction> Reaction { get; set; }
        public virtual ICollection<StatusInBoxChat> StatusInBoxChat { get; set; }
    }
}