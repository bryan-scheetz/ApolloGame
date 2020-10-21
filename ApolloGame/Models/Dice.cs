using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloGame.Models
{
    public class Dice
    {
        public int currentFace { get; set; }


        public void Roll()
        {
            var rand = new Random();
            this.currentFace = rand.Next(7);
        }

    }
}
