using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_Pattern01_Prototype
{
    abstract internal class Prototype
    {
        string id;
        // Constructor
        public Prototype(string id)
        {
            this.id = id;
        }
        // Gets id
        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
}
