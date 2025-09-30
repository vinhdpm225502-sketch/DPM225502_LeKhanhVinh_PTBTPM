namespace DPM225502_LeKhanhVinh_DreamWorld01_Adapter {
    public class Program
    {
        public static void Main()
        {
            // Non-adapted chemical compound 
            var unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            var water = new RichCompound(Chemical.Water);
            water.Display();
            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();
            var ethanol = new RichCompound(Chemical.Ethanol);
            ethanol.Display();
            // Wait for user
            Console.ReadKey();
        }
    }
}