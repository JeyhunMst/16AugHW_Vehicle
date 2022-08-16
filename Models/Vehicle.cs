using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugTask2_VehicleClass.Models
{
    abstract class Vehicle
    {
        public abstract decimal DriveTime { get; set; }
        public abstract decimal DrivePath { get; set; }
        public abstract void AvarageSpeed();

    }
}
