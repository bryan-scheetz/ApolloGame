using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloGame.Models
{
    public class Slider
    {
        public int CurrentPosition { get; set; }

        public Log SliderLog;

        public Slider()
        {
            this.SliderLog = new Log();
            this.CurrentPosition = 8;
        }
        public void Increment()
        {
            if(this.CurrentPosition < 8)
            {
                this.CurrentPosition++;
            } else
            {
                this.SliderLog.Record.Add("Wasted Increment!");
            }
            
        }

        public void Decrement()
        {
            if(this.CurrentPosition > 0)
            {
                this.CurrentPosition--;
            } else
            {
                // what happens if we're already at 0?
            }
            
        }

    }
}
