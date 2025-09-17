using DPM225502_LeKhanhVinh_Real01_FactoryMethod.DocumentClass;
using DPM225502_LeKhanhVinh_Real01_FactoryMethod.PageClass;

namespace DPM225502_LeKhanhVinh_Real01_FactoryMethod
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
}