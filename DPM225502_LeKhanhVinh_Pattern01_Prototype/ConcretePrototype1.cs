﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_Pattern01_Prototype
{
    internal class ConcretePrototype1 : Prototype
    {

        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
