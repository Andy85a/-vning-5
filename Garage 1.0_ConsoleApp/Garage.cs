using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0_ConsoleApp
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        UIc uic = new UIc();
        
        private Vehicle[] vehiclearray = new Vehicle[5];
        

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }






        //antalet bilar
        //ta bort eller lägg till bilar
        //
    }
}
