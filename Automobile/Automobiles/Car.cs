using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile.Automobiles
{
    public class Car : AutomobileBase
    {
        private int countPassengers;
        private int maxCountPassengers;

        private const string _maxCountPassengersException = "Максимальное число пассажиров не может быть меньше 1";
        private const string _countPassengers = "Число пассажиров не может превышать максимальное количество пассажиров";
        public int MaxCountPassengers 
        { 
            get 
            {
                return this.maxCountPassengers;
            }
            private set 
            {
                if (value > 0) this.maxCountPassengers = value;
                else throw new ArgumentException(_maxCountPassengersException);
            }
        }
        public int CountPassengers 
        {
            get { return countPassengers; }
            set
            {
                if (value >= 1 && value <= MaxCountPassengers) countPassengers = value;
                else throw new ArgumentException(_countPassengers);
            }
        }
        public Car(int speed, double averageFuelConsumption, int fuelTankVolume, double residualFuelTankVolume, int maxCountPassengers, int countPassengers) 
            : base(speed, averageFuelConsumption, fuelTankVolume, residualFuelTankVolume)
        {
            this.MaxCountPassengers = maxCountPassengers;
            this.CountPassengers = countPassengers;
        }
        public override double PowerReserveFullTank() => this.FuelTankVolume / this.AverageFuelConsumption * 100;
        public override double PowerReserveResidualTank() => this.ResidualFuelTankVolume / this.AverageFuelConsumption * 100;
        public double PowerReserveResidualTankWithPassengaers() => this.ResidualFuelTankVolume / this.AverageFuelConsumption * (1 - 0.06 * (this.CountPassengers - 1)) * 100;
        
    }
}
