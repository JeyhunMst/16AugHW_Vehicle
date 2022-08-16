using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugTask2_VehicleClass.Models
{
    interface IEngine
    {
        public decimal HorsePower { get; set; }
        public decimal TankSize { get; set; }
        public decimal CurrentOil { get; set; }
        public string FuelType { get; set; }
        void RemainOilAmount();
    }
}
