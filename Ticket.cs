using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLotSimulation
{
    public class Ticket
    {
        public string vehicleNumberr { get; set; }

        public int slotNumber { get; set; }

        public string intime;

        public enum vehicleType {Two_Wheeler=1,Four_Wheeler=2,Heavy_Wheeler=3};
    }
}
