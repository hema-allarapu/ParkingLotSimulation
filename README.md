# ParkingLotSimulation
The purpose of this simulation is to track and manage occupancy of a parking lot and
allow customers to find and reserve available parking places.
The Parking lot allows customers to park Vehicle according to their size and
slot availability. The Lot has
 M number of 2 Wheeler parking.
 N number of 4 Wheeler parking.
 O number of heavy vehicle parking.
Vehicle of one type can only park in areas designated for the vehicle type.
As the vehicle enters the Parking lot the system checks for an available parking slot
for the vehicle type. If a slot is available it issues a parking ticket. Else the system
refuses to allow parking of the vehicle.
The parking ticket contains
 Vehicle Number
 Slot Number
 In Time
 Out Time
Once the vehicle is parked at a slot the slot is marked occupied.
When a vehicle moves out of a slot it is marked free, and theparking ticket is
returned to the Parking Lot system.
Simulate a parking lot system using a console application. The simulation should allow you to
 Initialize a parking lot.
 See Parking Lot current occupancy details.
 Park Vehicle and Issue Ticket.
 Un-park Vehicle.
