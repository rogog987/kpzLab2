using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneFactoryLibrary
{
    public class AirplaneFactoryLibrary
    {
        public abstract class Airplane
        {
            public string Model { get; set; }
            public int Capacity { get; set; }
            public int Range { get; set; }

            public override string ToString()
            {
                return $"{Model}: Capacity={Capacity}, Range={Range} km";
            }
        }

        // Конкретні класи літаків
        public class AirbusAirplane : Airplane
        {
            public AirbusAirplane()
            {
                Model = "Airbus A320";
                Capacity = 180;
                Range = 6100;
            }
        }

        public class BoeingAirplane : Airplane
        {
            public BoeingAirplane()
            {
                Model = "Boeing 737";
                Capacity = 200;
                Range = 6570;
            }
        }

        public class EmbraerAirplane : Airplane
        {
            public EmbraerAirplane()
            {
                Model = "Embraer E195";
                Capacity = 120;
                Range = 4260;
            }
        }

        // Абстрактна фабрика
        public abstract class AirplaneFactory
        {
            public abstract Airplane CreateAirplane();
        }

        // Конкретні фабрики
        public class AirbusFactory : AirplaneFactory
        {
            public override Airplane CreateAirplane()
            {
                return new AirbusAirplane();
            }
        }

        public class BoeingFactory : AirplaneFactory
        {
            public override Airplane CreateAirplane()
            {
                return new BoeingAirplane();
            }
        }

        public class EmbraerFactory : AirplaneFactory
        {
            public override Airplane CreateAirplane()
            {
                return new EmbraerAirplane();
            }
        }
    }
}
