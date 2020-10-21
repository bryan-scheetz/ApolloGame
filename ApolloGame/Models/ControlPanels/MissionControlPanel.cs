using ApolloGame.Models.MissionControlMeters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloGame.Models
{
    public class MissionControlPanel
    {

        CommunicationMeter communication = new CommunicationMeter();
        ExperimentMeter experiment = new ExperimentMeter();
        FlightControlMeter flight = new FlightControlMeter();
        LifeSupportMeter lifeSupport = new LifeSupportMeter();
        PowerDistributionMeter power = new PowerDistributionMeter();


        public void Adjust(String system, int gain)
        {
            
        }

    }
}
