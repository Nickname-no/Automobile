
using Automobile.Automobiles;

namespace Automobile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AutomobileBase> automobiles = new List<AutomobileBase>();
            try
            {
                automobiles.Add(new Car(200, 10, 40, 30, 5, 3));
                automobiles.Add(new SportCar(250, 15, 40, 30));
                automobiles.Add(new Truck(120, 30, 300, 200, 10000, 1000));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (AutomobileBase automobile in automobiles)
            {
                Console.WriteLine($"Расстояние, которое может преодолеть транспортное средство на полном баке в километрах: {automobile.PowerReserveFullTank()}");
                Console.WriteLine($"Расстояние, которое может преодолеть транспортное средство на остаточном баке в километрах: {automobile.PowerReserveResidualTank()}");
                Console.WriteLine($"Время, затраченное на перемещение транспортного средства на 100 км  в часах: {automobile.TravelTime(100)}");
                if (automobile is Car car)
                    Console.WriteLine($"Расстояние, которое может преодолеть транспортное средство на остаточном баке в километрах с учетом количества пассажиров: {car.PowerReserveResidualTankWithPassengaers()}");
                else if(automobile is Truck truck)
                    Console.WriteLine($"Расстояние, которое может преодолеть транспортное средство на остаточном баке в километрах с учетом веса грузов: {truck.PowerReserveResidualTankWithCargoWeight()}");
            }

        }
    }
}