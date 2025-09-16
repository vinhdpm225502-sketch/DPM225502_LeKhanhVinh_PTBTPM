using DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory;
using DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Factories;

class Program
{
    public static void Main()
    {
        // Abstract factory #1
        ThemeFactory darkTheme = new DarkTheme();
        Client client1 = new Client(darkTheme);
        client1.Run();

        // Abstract factory #2
        ThemeFactory lightTheme = new LightTheme();
        Client client2 = new Client(lightTheme);
        client2.Run();
        // Wait for user input
        Console.ReadKey();
    }
}