using _16AugTask2_VehicleClass.Models;
using System;

namespace _16AugTask2_VehicleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carNo = new Car
            {
                DrivePath = 231,
                DriveTime = 12
            };
            carNo.AvarageSpeed();
            Bicycle bicycleNo = new Bicycle
            {
                DrivePath=213,
                DriveTime=21
            };
            bicycleNo.AvarageSpeed();
            Plane planeNo = new Plane
            {
                DrivePath = 21,
                DriveTime = 10
            };
            planeNo.AvarageSpeed();


            
        }
    }
}
