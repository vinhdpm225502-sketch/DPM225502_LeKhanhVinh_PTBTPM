using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_Real01_Builder
{
    abstract internal class VehicleBuilder
    {
        protected Vehicle vehicle;
        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
