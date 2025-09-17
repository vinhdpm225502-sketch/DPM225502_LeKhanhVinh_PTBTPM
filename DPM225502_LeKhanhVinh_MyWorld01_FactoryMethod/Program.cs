using DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.SectionClass;
using DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.WidgetClass;
using System.Reflection.Metadata;

namespace DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Section[] sections = new Section[2];
            sections[0] = new Header();
            sections[1] = new Body();

            foreach (Section section in sections)
            {
                Console.WriteLine("\nSuggest for " + section.GetType().Name + " section --");
                foreach(Widget widget in section.Widgets)
                {
                    Console.WriteLine("" + widget.GetType().Name);
                }
            }
            Console.ReadKey();

        }
    }
}