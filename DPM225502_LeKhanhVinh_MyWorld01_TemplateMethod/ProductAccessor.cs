using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_TemplateMethod
{
    public class ProductAccessor : DataAccessor<Product>
    {
        public override void Select()
        {
            Items.Add(new Product { ProductName = "Car" });
            Items.Add(new Product { ProductName = "Bike" });
            Items.Add(new Product { ProductName = "Boat" });
            Items.Add(new Product { ProductName = "Truck" });
            Items.Add(new Product { ProductName = "Moped" });
            Items.Add(new Product { ProductName = "Rollerskate" });
            Items.Add(new Product { ProductName = "Stroller" });
        }
        public override void Process(int top)
        {
            Console.WriteLine("Products ---- ");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(Items[i].ProductName);
            }
            Console.WriteLine();
        }
    }
}
