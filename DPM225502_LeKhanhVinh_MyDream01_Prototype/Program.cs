namespace DPM225502_LeKhanhVinh_MyDream01_Prototype
{
    internal static class Program
    {
        static void Main()
        {
            WidgetManager widgetManager = new WidgetManager();

            widgetManager["button"] = new Widget("button", 50, 10, 10, 15);
            
            widgetManager["textformfield"] = new Widget("textformfield", 50, 10, 10, 15);

            Widget button = widgetManager["textformfield"].Clone() as Widget;

            Console.ReadKey();
        }
    }
}