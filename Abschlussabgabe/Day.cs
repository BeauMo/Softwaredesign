using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Day
    {
        public Day()
        {
            //blocksPerDay wäre vielleicht passender
            this.blocksOnDay = new Block[6]{new Block(),new Block(),new Block(),new Block(),new Block(),new Block(),};
        }
        public Block[] blocksOnDay;

    }
}
