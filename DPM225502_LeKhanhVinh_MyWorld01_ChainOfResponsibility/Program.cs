namespace DPM225502_LeKhanhVinh_MyWorld01_ChainOfResponsibility
{
    public class Program
    {
        public static void Main()
        {
            // Setup Chain of Responsibility
            var larry = new Director();
            var sam = new VicePresident();
            var tammy = new President();
            larry.Successor = sam;
            sam.Successor = tammy;
            // Generate and process purchase requests
            var purchase = new Purchase { Number = 2034, Amount = 350.00, Purpose = "Supplies" };
            larry.ProcessRequest(purchase);
            purchase = new Purchase { Number = 2035, Amount = 32590.10, Purpose = "Project X" };
            larry.ProcessRequest(purchase);
            purchase = new Purchase { Number = 2036, Amount = 122100.00, Purpose = "Project Y" };
            larry.ProcessRequest(purchase);
            // Wait for user
            Console. ReadKey();
        }
    }
    public record Purchase
    {
        public required double Amount { get; init; }
        public required string Purpose { get; init; }
        public required int Number { get; init; }
    }
}