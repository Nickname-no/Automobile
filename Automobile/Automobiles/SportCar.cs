using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile.Automobiles
{
    public class SportCar : AutomobileBase
    {
        public SportCar(int speed, double averageFuelConsumption, int fuelTankVolume, double residualFuelTankVolume) 
            : base(speed, averageFuelConsumption, fuelTankVolume, residualFuelTankVolume)
        {}

        public override double PowerReserveFullTank() => this.FuelTankVolume / this.AverageFuelConsumption * 100;
        public override double PowerReserveResidualTank() => this.ResidualFuelTankVolume / this.AverageFuelConsumption * 100;
    }
}
