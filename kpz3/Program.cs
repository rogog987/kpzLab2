using System;
using static AirplaneFactoryLibrary.AirplaneFactoryLibrary;

namespace FactoryMethodExample
{
      class Program
    {
        static void Main(string[] args)
        {
            // Використання фабрик
            AirplaneFactory airbusFactory = new AirbusFactory();
            AirplaneFactory boeingFactory = new BoeingFactory();
            AirplaneFactory embraerFactory = new EmbraerFactory();

            Airplane airbus = airbusFactory.CreateAirplane();
            Airplane boeing = boeingFactory.CreateAirplane();
            Airplane embraer = embraerFactory.CreateAirplane();

            Console.WriteLine(airbus);
            Console.WriteLine(boeing);
            Console.WriteLine(embraer);
        }
    }
}
