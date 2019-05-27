using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLotSimulation
{
    public class ParkingSlot
    {       
        public int slotId { get; set; }

        public int slotNumber {get ; set; }

        public int slotType { get; set; }

        public string vechileNumber { get; set; }

        public Vehicle parkedVehicle { get; set; }

        public bool isAvaliable { get; set; }
        

        public void Park(Vehicle vehicle)
        {
            if (parkedVehicle == null)
            {
                parkedVehicle = vehicle;
                isAvaliable = false;
            }
        }


        public void Unpark(Vehicle vehicle)
        {
            parkedVehicle = null;
            isAvaliable = true;
        }

    }
}
 
