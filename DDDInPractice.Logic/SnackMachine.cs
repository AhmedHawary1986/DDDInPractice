using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.Logic
{
    public sealed class SnackMachine
    {
        public int OneCentCount { get; private set; }
        public int FiveCentCount { get; private set; }

        public int QuarterCount { get; private set; }

        public int OneDollarCount { get; private set; }

        public int FiveDollarCount { get; private set; }

        public int TwentyDollarCount { get; private set; }
    }
}
