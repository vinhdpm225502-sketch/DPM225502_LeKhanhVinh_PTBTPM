using DPM225502_LeKhanhVinh_MyWorld01_Builder.UI;

namespace DPM225502_LeKhanhVinh_MyWorld01_Builder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WidgetWebBuilder builder;
            UIManagement uiManagement = new UIManagement();

            builder = new ButtonWidget();
            uiManagement.Contruct(builder);
            builder.WidgetWeb.Show();

            builder = new TextFormFieldWidget();
            uiManagement.Contruct(builder);
            builder.WidgetWeb.Show();

            Console.ReadKey();
        }
    }
}