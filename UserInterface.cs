using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLotSimulation
{
    public class UserInterface
    {
        int input;
        public enum vehicleType_{Two_Wheeler=1,Four_Wheeler=2,Heavy_Wheeler=3};
        String vehiclenumber_;
        public int numberofTwoWheelerSlots, numberofFourWheelerSlots, numberofHeavyWheelerSlots;
        Vehicle vehicle = new Vehicle();
        ParkingSlot parkingSlot = new ParkingSlot();
        Ticket ticket = new Ticket();
        TicketCounter ticketcounter = new TicketCounter();

        public UserInterface()
        {
            Console.WriteLine("Enter number of 2 wheeler parking");
            numberofTwoWheelerSlots = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of 4 wheeler parking");
            numberofFourWheelerSlots = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of heavy wheeler parking");
            numberofHeavyWheelerSlots = Convert.ToInt32(Console.ReadLine());
            ParkingLot parkingLot = new ParkingLot(numberofTwoWheelerSlots, numberofFourWheelerSlots, numberofHeavyWheelerSlots);

            Console.WriteLine("\n");
            Console.WriteLine("-------------------Slot available-----------------------");
            Console.WriteLine("\n");
            for (int i = 0; i < parkingLot.Slots.Count; i++)
            {
                if (parkingLot.Slots[i].slotType == (int)vehicleType_.Two_Wheeler)
                {
                    if (parkingLot.Slots[i].isAvaliable == true)
                        Console.WriteLine("For {0} Slot {1} is avaliable", vehicleType_.Two_Wheeler, i);
                    else
                        Console.WriteLine("For {0} Slot {1} is not avaliable", vehicleType_.Two_Wheeler, i);
                }
                if (parkingLot.Slots[i].slotType == (int)vehicleType_.Four_Wheeler)
                {
                    if (parkingLot.Slots[i].isAvaliable == true)
                        Console.WriteLine("For {0} Slot {1} is avaliable", vehicleType_.Four_Wheeler, i);
                    else
                        Console.WriteLine("For {0} Slot {1} is not avaliable", vehicleType_.Four_Wheeler, i);
                }
                if (parkingLot.Slots[i].slotType == (int)vehicleType_.Heavy_Wheeler)
                {
                    if (parkingLot.Slots[i].isAvaliable == true)
                        Console.WriteLine("For {0} Slot {1} is avaliable", vehicleType_.Heavy_Wheeler, i);
                    else
                        Console.WriteLine("For {0} Slot {1} is not avaliable", vehicleType_.Heavy_Wheeler, i);
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Enter vehicle type");
            Console.WriteLine("\n1)Two-Wheeler\t2)Four-Wheeler\t3)Heavy-Wheeler");
            vehicle.vehicletype = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vehicle number");
            vehicle.vehicleNumber = Console.ReadLine();
            Console.WriteLine("Enter the slot number where you want to park");
            parkingSlot.slotNumber = Convert.ToInt32(Console.ReadLine());
            ticket.slotNumber = parkingSlot.slotNumber;
            parkingLot.AssignParkingSlot(vehicle,parkingSlot);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------\\Ticket\\-----------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Vehicle number:{0}", vehicle.vehicleNumber);
            Console.WriteLine("Slot number:{0}", ticket.slotNumber);
            Console.WriteLine("Intime:{0}", ticket.intime = DateTime.Now.ToString("HH:mm:ss tt"));
            Console.WriteLine("Outtime: _____");
            ticketcounter.StoreTicket(ticket, vehicle, parkingLot);


            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("\n");
                Console.WriteLine("Enter number\n 1)Park vehicle 2)Un-park vehicle");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------Slot available-----------------------");
                    Console.WriteLine("\n");
                    for (int i = 0; i < parkingLot.Slots.Count; i++)
                    {
                        if (parkingLot.Slots[i].slotType == (int)vehicleType_.Two_Wheeler)
                        {
                            if (parkingLot.Slots[i].isAvaliable == true)
                                Console.WriteLine("For {0} Slot {1} is avaliable", vehicleType_.Two_Wheeler, i);
                            else
                                Console.WriteLine("For {0} Slot {1} is not avaliable", vehicleType_.Two_Wheeler, i);
                        }
                        if (parkingLot.Slots[i].slotType == (int)vehicleType_.Four_Wheeler)
                        {
                            if (parkingLot.Slots[i].isAvaliable == true)
                                Console.WriteLine("For {0} Slot {1} is avaliable", vehicleType_.Four_Wheeler, i);
                            else
                                Console.WriteLine("For {0} Slot {1} is not avaliable", vehicleType_.Four_Wheeler, i);
                        }
                        if (parkingLot.Slots[i].slotType == (int)vehicleType_.Heavy_Wheeler)
                        {
                            if (parkingLot.Slots[i].isAvaliable == true)
                                Console.WriteLine("For {0} Slot {1} is avaliable", vehicleType_.Heavy_Wheeler, i);
                            else
                                Console.WriteLine("For {0} Slot {1} is not avaliable", vehicleType_.Heavy_Wheeler, i);
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Enter vehicle type");
                    Console.WriteLine("\n1)Two-Wheeler\t2)Four-Wheeler\t3)Heavy-Wheeler");
                    vehicle.vehicletype = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter vehicle number");
                    vehicle.vehicleNumber = Console.ReadLine();
                    Console.WriteLine("Enter the slot number where you want to park");
                    parkingSlot.slotNumber = Convert.ToInt32(Console.ReadLine());
                    ticket.slotNumber = parkingSlot.slotNumber;
                    parkingLot.AssignParkingSlot(vehicle,parkingSlot);
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------\\Ticket\\-----------------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("Vehicle number:{0}", vehicle.vehicleNumber);
                    Console.WriteLine("Slot number:{0}", ticket.slotNumber);
                    Console.WriteLine("Intime:{0}", ticket.intime = DateTime.Now.ToString("HH:mm:ss tt"));
                    Console.WriteLine("Outtime: _____");
                    ticketcounter.StoreTicket(ticket, vehicle, parkingLot);
                }

                if (input == 2)
                {
                    parkingLot.EmptyTheSlot(vehicle);
                    Console.WriteLine("Enter vehicle number");
                    vehiclenumber_ = Console.ReadLine();
                    foreach (Ticket _ticket in ticketcounter.tickets)
                        if (_ticket.vehicleNumberr == vehiclenumber_)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("-------------------\\Return Ticket\\-----------------------");
                            Console.WriteLine("\n");
                            Console.WriteLine("Vehicle number:{0}", vehiclenumber_);
                            Console.WriteLine("Slot number:{0}", _ticket.slotNumber);
                            Console.WriteLine("Intime:{0}", _ticket.intime);
                            Console.WriteLine("Outtime:{0}", DateTime.Now.ToString("HH:mm:ss tt"));
                        }
                }
            }

 
        }
    }
}
