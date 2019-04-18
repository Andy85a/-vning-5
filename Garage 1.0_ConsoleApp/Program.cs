using System;

namespace Garage_1._0_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UIc uic = new UIc();
            uic.MenuMethod();
            

            Console.WriteLine("Välkommen till garaget");
            Console.ReadKey();
        }
    }
}
