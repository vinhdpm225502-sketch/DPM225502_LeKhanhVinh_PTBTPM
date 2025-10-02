﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Observer
{
    public class Investor : IInvestor
    {
        // Gets or sets the investor name
        public string Name { get; set; } = null!;
        // Gets or sets the stock
        public Stock Stock { get; set; } = null!;
        public void Update(object sender, ChangeEventArgs e)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", Name, e.Symbol, e.Price);
        }
    }
}
