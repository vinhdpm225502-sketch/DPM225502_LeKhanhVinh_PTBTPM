using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Interpreter
{
    public class TenExpression : Expression
    {
        public override string One() => "X";
        public override string Four() => "XL";
        public override string Five() => "L";
        public override string Nine() => "XC";
        public override int Multiplier() => 10;
    }
}
