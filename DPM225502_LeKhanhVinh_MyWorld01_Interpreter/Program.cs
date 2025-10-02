namespace DPM225502_LeKhanhVinh_MyWorld01_Interpreter
{
    public class Program
    {
        public static void Main()
        {
            // Construct the 'parse tree'
            List<Expression> tree = [ new ThousandExpression(), new HundredExpression(),
                                  new TenExpression(), new OneExpression() ];
            // Create the context (i.e. roman value)
            var roman = "MCMXXVIII";
            var context = new Context { Input = roman };
            // Interpret
            tree.ForEach(e => e.Interpret(context));
            Console.WriteLine($"{roman} = {context.Output}");
            // Wait for user
            Console.ReadKey();
        }
    }
    

}