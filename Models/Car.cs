using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugTask2_VehicleClass.Models
{
    class Car : Vehicle, IWheel,ITransmission,IEngine
    {
        private string _winCode;

        public string WinCode
        {
            get { return _winCode; }
            set
            {
                if (value.Length>=11 && value.Length<=17)
                {
                    _winCode = value;
                }
            }
        }

        private int _doorCount=4;

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value>=1 && value<=6)
                {
                    _doorCount = value;
                }
            }
        }

        public decimal HorsePower { get ; set ; }
        public decimal TankSize { get ; set ; }
        public decimal CurrentOil { get ; set ; }
        public string FuelType { get ; set ; }  
        public void RemainOilAmount()
        {
            Console.WriteLine(CurrentOil);
        }
        public decimal WheelThickness { get; set ; }
        public string Transmission { get ; set; }
        public override decimal DriveTime { get ; set; }
        public override decimal DrivePath { get ; set; }
        public override void AvarageSpeed()
        {
            Console.WriteLine(DrivePath/DriveTime);
        }

      

        
    }
}
