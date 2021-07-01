using System;

namespace Day2
{
   class Program
    {
        static void Main(string[] args)
        {
            Mobile Jeep = new Mobile(4, "JEEP", "It is used to travel", "Mobile");
            Console.WriteLine($"Name of Equipment = {Jeep.GetName()} , Desciption = {Jeep.GetDescription()} , Type = {Jeep.Gettype()}");
            Console.WriteLine($"Distance Moved = {Jeep.GetDistanceMoved()} , Maintainace Cost = {Jeep.GetMaintainanceCost()}");
            Jeep.MoveBy(5);
            Console.WriteLine($"Distance Moved = {Jeep.GetDistanceMoved()} , Maintainace Cost = {Jeep.GetMaintainanceCost()}");
            Jeep.MoveBy(6);
            Console.WriteLine($"Distance Moved = {Jeep.GetDistanceMoved()} , Maintainace Cost = {Jeep.GetMaintainanceCost()}");

            Console.WriteLine("");

            Immobile Trolley = new Immobile(5, "Trolley", "It is used to carry Luggage", "Immobile");
            Console.WriteLine($"Name of Equipment = {Trolley.GetName()} , Desciption = {Trolley.GetDescription()} , Type = {Trolley.Gettype()}");
            Console.WriteLine($"Distance Moved = {Trolley.GetDistanceMoved()} , Maintainace Cost = {Trolley.GetMaintainanceCost()}");
            Trolley.MoveBy(6);
            Console.WriteLine($"Distance Moved = {Trolley.GetDistanceMoved()} , Maintainace Cost = {Trolley.GetMaintainanceCost()}");
            Trolley.MoveBy(3);
            Console.WriteLine($"Distance Moved = {Trolley.GetDistanceMoved()} , Maintainace Cost = {Trolley.GetMaintainanceCost()}");



        }
    }
}
