using ApolloGame.Models.FlightSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloGame.Models
{
    public class AstronautControlPanel
    {
        AstronautControlPanel()
        {
            CommunicationSystem comms = new CommunicationSystem();
            ExperimentSystem experiment = new ExperimentSystem();
            FlightControlSystem flight = new FlightControlSystem();
            LifeSupportSystem lifeSupport = new LifeSupportSystem();
            PowerDistributionSystem power = new PowerDistributionSystem();
        }
       


    }
}
