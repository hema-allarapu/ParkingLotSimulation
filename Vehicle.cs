using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLotSimulation
{
   public class Vehicle
    {
        public string vehicleNumber{get;set;}
        public int vehicletype{get;set;}
        public enum vehicleType {Two_Wheeler=1,Four_Wheeler=2,Heavy_Wheeler=3};
    }
}
