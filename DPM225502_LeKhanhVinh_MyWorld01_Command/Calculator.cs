using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Command
{
    public class Calculator
    {
        private int current = 0;
        // Perform operation for given operator and operand
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': current += operand; break;
                case '-': current -= operand; break;
                case '*': current *= operand; break;
                case '/': current /= operand; break;
            }
            Console.WriteLine(
                "Current value = {0,3} (following {1} {2})",
                current, @operator, operand);
        }
    }
}
