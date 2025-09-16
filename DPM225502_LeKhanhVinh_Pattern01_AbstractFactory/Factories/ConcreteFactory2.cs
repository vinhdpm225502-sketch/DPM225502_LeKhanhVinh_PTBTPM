using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DPM225502_LeKhanhVinh_Pattern01_AbstractFactory.Products;

namespace DPM225502_LeKhanhVinh_Pattern01_AbstractFactory.Factories
{
    internal class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
