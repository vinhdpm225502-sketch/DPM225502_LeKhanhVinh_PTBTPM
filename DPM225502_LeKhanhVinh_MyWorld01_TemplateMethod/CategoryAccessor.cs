using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_TemplateMethod
{
    public class CategoryAccessor : DataAccessor<Category>
    {
        public override void Select()
        {
            Items.Add(new() { CategoryName = "Red" });
            Items.Add(new() { CategoryName = "Green" });
            Items.Add(new() { CategoryName = "Blue" });
            Items.Add(new() { CategoryName = "Yellow" });
            Items.Add(new() { CategoryName = "Purple" }); ;
            Items.Add(new() { CategoryName = "White" });
            Items.Add(new() { CategoryName = "Black" });
        }
        public override void Process(int top)
        {
            Console.WriteLine("Categories ---- ");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(Items[i].CategoryName);
            }
            Console.WriteLine();
        }
    }
}
