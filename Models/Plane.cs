using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugTask2_VehicleClass.Models
{
    class Plane:Vehicle,IEngine,IWheel
    {
        private decimal _wingLength;

        public decimal WingLength
        {
            get { return _wingLength; }
            set 
            {
                if (value>1 && value<100)
                {
                    _wingLength = value;
                } 
            }
        }

        public decimal WheelThickness { get ; set ; }
        public decimal HorsePower { get ; set ; }
        public decimal TankSize { get ; set ; }
        public decimal CurrentOil { get ; set ; }
        public string FuelType { get ; set ; }
        public override decimal DriveTime { get; set ; }
        public override decimal DrivePath { get ; set ; }

        public override void AvarageSpeed()
        {
            Console.WriteLine(DrivePath/DriveTime);
        }

        public void RemainOilAmount()
        {
            Console.WriteLine(CurrentOil ); 
        }
    }
}
