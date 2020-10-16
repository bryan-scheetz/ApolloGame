using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloGame.Models
{
    public class MissionControlPanel
    {
        public Slider FlightControl;
        public Slider PowerDistrubution;
        public Slider LifeSupport;
        public Slider Communications;
        public Slider Experiments;

        public void Adjust(String system, int gain)
        {
            
        }

    }
}
