using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0_ConsoleApp
{
    public class Vehicle
    {
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NrofDoors { get; set; }
        public int NrOfHP { get; set; }
        public Vehicle(string regNo, string color, int nrofDoors, int nrOfHP)
        {
            RegNo = regNo;
            Color = color;
            NrofDoors = nrofDoors;
            NrOfHP = nrOfHP;
        }

    }
}
