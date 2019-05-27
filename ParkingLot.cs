using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLotSimulation
{
    public class ParkingLot
    {
        public enum vehicleType { Two_Wheeler = 1, Four_Wheeler = 2, Heavy_Wheeler = 3 };

        public List<ParkingSlot> Slots = new List<ParkingSlot>();


        public ParkingLot(int numberofTwoWheelerSlots, int numberofFourWheelerSlots, int numberofHeavyWheelerSlots)
        {
            for (int i = 0; i < numberofTwoWheelerSlots; i++)
            {
                Slots.Add(new ParkingSlot {slotType = (int)vehicleType.Two_Wheeler, isAvaliable = true });
            }
            for (int i = 0; i < numberofFourWheelerSlots; i++)
            {
                Slots.Add(new ParkingSlot { slotType = (int)vehicleType.Four_Wheeler, isAvaliable = true });
            }
            for (int i = 0; i < numberofHeavyWheelerSlots; i++)
            {
                Slots.Add(new ParkingSlot { slotType = (int)vehicleType.Heavy_Wheeler, isAvaliable = true });
            }
        }


        public void AssignParkingSlot(Vehicle vehicle,ParkingSlot parkingSlot)
        {
            int i = 0;
            foreach(ParkingSlot slot in Slots)
            { 
                if (parkingSlot.slotNumber==i)
                {
                    if (slot.isAvaliable == true)
                    {
                        slot.isAvaliable = false;
                        slot.vechileNumber=vehicle.vehicleNumber;
                        break;
                    }
                }
                i++;
            }
        }


        public void EmptyTheSlot(Vehicle vehicle)
        {
            foreach (ParkingSlot slot in Slots)
            {
                if (slot.vechileNumber== vehicle.vehicleNumber)
                {
                    slot.isAvaliable = false;
                }
            }
        }


    } 
}
