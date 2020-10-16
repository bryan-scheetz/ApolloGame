// Base class for all mission control meters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloGame.Models
{
    public abstract class Meter
    {
        public int CurrentPosition { get; set; }
        public bool InCrisis { get; set; }

        public Log SliderLog;
        public Meter()
        {
            this.CurrentPosition = 8;
        }
        // Incrememnt the slider
        public void Increment()
        {
            if(this.CurrentPosition < 8)
            {
                this.CurrentPosition++;
            } else
            {
                // Wasted Increment 
            }
            
        }
        // Decrement the slider
        public void Decrement()
        {
            if(this.CurrentPosition > 0)
            {
                this.CurrentPosition--;
            } else
            {
                // what happens if we're already at 0?
                this.InCrisis = true;
            }
            
        }

        // Return special abilities based on current position
        public abstract void SpecialRange(Astronaut astronaut);
    }
}
