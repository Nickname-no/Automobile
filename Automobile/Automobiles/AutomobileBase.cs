using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile.Automobiles
{
    public abstract class AutomobileBase
    {
        private int speed;
        private double averageFuelConsumption;
        private int fuelTankVolume;
        private double residualFuelTankVolume;

        private const string _speedException = "Скорость не может быть отрицательной";
        private const string _averageFuelConsumptionException = "Средний росход топлива не может быть отрицательным";
        private const string _residualFuelConsumptionException = "Остаточный объем топливного бака не может быть отрицательным или больше чем объем топливного бака";
        private const string _fuelTankVolumeException = "Объем топливного бака не может быть отрицательным";

        public int Speed 
        {
            get
            {
                return this.speed;
            }
            protected set 
            {
                if (value > 0) this.speed = value;
                else throw new ArgumentException(_speedException);
            } 
        }
        public double AverageFuelConsumption 
        {
            get
            {
                return this.averageFuelConsumption;
            }
            protected set
            {
                if (value > 0) this.averageFuelConsumption = value;
                else throw new ArgumentException(_averageFuelConsumptionException);
            }
        }
        public int FuelTankVolume 
        {
            get
            {
                return this.fuelTankVolume;
            }
            protected set
            {
                if (value > 0) this.fuelTankVolume = value;
                else throw new ArgumentException(_fuelTankVolumeException);
            }
        }
        public double ResidualFuelTankVolume
        {
            get
            {
                return this.residualFuelTankVolume;
            }
            set
            {
                if ((value > 0) && (value < FuelTankVolume)) this.residualFuelTankVolume = value;
                else throw new ArgumentException(_residualFuelConsumptionException);
            }
        }

        public AutomobileBase(int speed, double averageFuelConsumption, int fuelTankVolume, double residualFuelTankVolume)
        {
            this.Speed = speed;
            this.AverageFuelConsumption = averageFuelConsumption;
            this.FuelTankVolume = fuelTankVolume;
            this.ResidualFuelTankVolume = residualFuelTankVolume;
        }

        public abstract double PowerReserveFullTank();
        public abstract double PowerReserveResidualTank();
        public double TravelTime(int distance) => (double)distance / this.Speed;

    }
}
