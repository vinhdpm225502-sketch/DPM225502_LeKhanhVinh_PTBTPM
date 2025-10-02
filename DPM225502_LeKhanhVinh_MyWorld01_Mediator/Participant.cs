﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Mediator
{
    public class Participant
    {
        // Gets or sets participant name
        public string Name { get; set; } = null!;
        // Gets or sets chatroom
        public Chatroom Chatroom { get; set; } = null!;
        // Send a message to given participant
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }
        // Receive message from participant
        public virtual void Receive(string from, string message)
        {
            WriteLine($"{from} to {Name}: '{message}'");
        }
    }
}
