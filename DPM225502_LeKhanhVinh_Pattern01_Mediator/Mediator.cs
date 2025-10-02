using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_Pattern01_Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message,
            Colleague colleague);
    }
}
