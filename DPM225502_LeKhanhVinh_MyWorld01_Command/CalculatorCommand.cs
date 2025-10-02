﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Command
{
    public class CalculatorCommand(Calculator calculator,
                                char @operator,
                                int operand) : ICommand
    {
        // Sets operator
        public char Operator { set => @operator = value; }
        // Sets operand
        public int Operand { set => operand = value; }
        // Execute command
        public void Execute()
        {
            calculator.Operation(@operator, operand);
        }
        // Unexecute command
        public void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }
        // Return opposite operator for given operator
        private static char Undo(char @operator)
        {
            return @operator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("@operator"),
            };
        }
    }
}
