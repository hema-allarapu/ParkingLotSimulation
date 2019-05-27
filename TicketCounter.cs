using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLotSimulation
{
    public class TicketCounter
    {
        public List<Ticket> tickets = new List<Ticket>();
        public void StoreTicket(Ticket ticket, Vehicle vehicle,ParkingLot parkingLot)
        {
            tickets.Add(new Ticket() { vehicleNumberr = vehicle.vehicleNumber, slotNumber = ticket.slotNumber, intime = ticket.intime });
        }
    }
}
