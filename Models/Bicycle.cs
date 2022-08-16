using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugTask2_VehicleClass.Models
{
  

    class Bicycle : Vehicle, IWheel
    {
        private string _pedalKind;

        public string PedalKind
        {
            get { return _pedalKind; }
            set { _pedalKind = value; }
        }

        public decimal WheelThickness { get; set; }
        public override decimal DriveTime{ get; set; }
        public override decimal DrivePath { get ; set; }

        public override void AvarageSpeed()
        {
           
            Console.WriteLine( DrivePath/DriveTime);
        }
    }
}
