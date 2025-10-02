using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Interpreter
{
    public class OneExpression : Expression
    {
        public override string One() => "I";
        public override string Four() => "IV";
        public override string Five() => "V";
        public override string Nine() => "IX";
        public override int Multiplier() => 1;
    }
}
