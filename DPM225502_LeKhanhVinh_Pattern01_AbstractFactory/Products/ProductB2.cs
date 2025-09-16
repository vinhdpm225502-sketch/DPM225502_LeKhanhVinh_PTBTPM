using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225502_LeKhanhVinh_Pattern01_AbstractFactory.Factories;

namespace DPM225502_LeKhanhVinh_Pattern01_AbstractFactory.Products
{
    internal class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
