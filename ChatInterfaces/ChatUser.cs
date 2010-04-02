// ----------------------------------------------------------------------------
// Copyright 2010 Wyle
// ----------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;

namespace ChatInterfaces
{
    [DataContract]
    public class ChatUser
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public DateTime LogInTime { get; set; }
    }
}