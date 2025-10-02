using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Mediator
{
    public class Beatle : Participant
    {
        public override void Receive(string from, string message)
        {
            Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
