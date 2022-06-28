using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile.Automobiles
{
    public class Truck : AutomobileBase
    {
        private double carryingCapacity;
        private double cargoWeight;

        private const string _carryingCapacityException = "Грузоподъемность грузового автомобиля не может быть отрицательным";
        private const string _cargoWeightException = "Вес грузов на транспорте не должен превышать грузоподъемность грузового автомобиля";

        public double CarryingCapacity 
        {
            get 
            {
                return this.carryingCapacity;
            }
            private set 
            {
                if (value > 0) this.carryingCapacity = value;
                else throw new ArgumentException(_carryingCapacityException);
            }
        }
        public double CargoWeight
        {
            get
            {
                return this.cargoWeight;
            }
            set
            {
                if (value < CarryingCapacity) this.cargoWeight = value;
                else throw new ArgumentException(_cargoWeightException);
            }
        }

        public Truck(int speed, double averageFuelConsumption, int fuelTankVolume, double residualFuelTankVolume, int carryingCapacity, int cargoWeight)
            : base(speed, averageFuelConsumption, fuelTankVolume, residualFuelTankVolume)
        {
            this.CarryingCapacity = carryingCapacity;
            this.CargoWeight = cargoWeight;
        }

        public override double PowerReserveFullTank() => this.FuelTankVolume / this.AverageFuelConsumption * 100;
        public override double PowerReserveResidualTank() => this.ResidualFuelTankVolume / this.AverageFuelConsumption * 100;
        public  double PowerReserveResidualTankWithCargoWeight() => this.ResidualFuelTankVolume / this.AverageFuelConsumption * (1 - 0.04 * this.CargoWeight / 200) * 100;
    }
}
