using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Interpreter
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public record Context
    {
        public string Input { get; set; } = null!;
        public int Output { get; set; }
    }
}
