using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Settings
    {
        public Settings(int[] orderBlocks, int maxBlocksPerDay, int minBlocksPerDay, int maxBlocksWithoutBreak, bool setWPMbefore)
        {
            this.orderBlocks = orderBlocks;
            this.maxBlocksPerDay = maxBlocksPerDay;
            this.minBlocksPerDay = minBlocksPerDay;
            this.maxBlocksWithoutBreak = maxBlocksWithoutBreak;
            this.setWPMbefore = setWPMbefore;

        }

        public int[] orderBlocks;
        public int maxBlocksPerDay;
        public int minBlocksPerDay;
        public int maxBlocksWithoutBreak;
        public bool setWPMbefore;
    }
}