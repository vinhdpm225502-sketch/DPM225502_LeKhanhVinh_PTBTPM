using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Proxy
{
    public class Math : IMath
    {
        public double Add(double x, double y) => x + y;
        public double Sub(double x, double y) => x - y;
        public double Mul(double x, double y) => x * y;
        public double Div(double x, double y) => x / y;
    }
}
