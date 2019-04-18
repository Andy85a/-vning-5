using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0_ConsoleApp
{

      public class UIc
    {
        public void GetGarageSize()
        {
            Console.WriteLine("Hej, välkommen till garaget, välj storlek på garaget, välj hur många fordon som ska få plats i garaget");
            int inputsize = Console.ReadLine()[0];
        }
        public void MenuMethod()
        {
            
            
            while (true)
            {


                Console.WriteLine("Hejsan, välkommen till garaget, gör ditt val"
                    + "\n1. List of parked vehicles"
                    + "\n2. List of type and inventory"
                    + "\n3. Add/Remove vehicle"
                    + "\n4. Find vehicle by regno"
                    + "\n5. Set Capacity for a new garage"
                    + "\n6. Find vehicle by properties"
                    + "\n7. Exit application");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {

                    Console.Clear();
                    Console.WriteLine("Välj en siffra tack");
                }
                switch (input)
                {
                    case '1':


                    default:
                        break;
                }
            }
        }
    }
}
