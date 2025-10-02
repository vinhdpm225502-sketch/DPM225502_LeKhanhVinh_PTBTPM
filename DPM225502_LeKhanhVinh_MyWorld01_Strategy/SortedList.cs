using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Strategy
{
    public class SortedList : List<Student>
    {
        // Sets sort strategy
        public ISortStrategy SortStrategy { get; set; } = null!;
        // Perform sort
        public void SortStudents()
        {
            SortStrategy.Sort(this);
            // Display sort results
            foreach (var student in this)
            {
                Console.WriteLine($" {student.Name}");
            }
            Console.WriteLine();
        }
    }
}
