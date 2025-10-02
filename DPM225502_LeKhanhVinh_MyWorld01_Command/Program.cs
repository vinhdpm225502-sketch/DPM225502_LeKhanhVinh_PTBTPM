namespace DPM225502_LeKhanhVinh_MyWorld01_Command
{
    public class Program
    {
        public static void Main()
        {
            // Create user and let her compute
            var user = new User();
            // Issue several compute commands
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            // Undo 4 commands
            user.Undo(4);
            // Redo 3 commands
            user.Redo(3);
            // Wait for user
            Console.ReadKey();
        }
    }
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}