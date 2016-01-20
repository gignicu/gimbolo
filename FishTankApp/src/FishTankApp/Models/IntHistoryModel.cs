using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTankApp.Models
{
    public class IntHistoryModel
    {
        public IntHistoryModel(DateTime timeStamp, int value)
        {
            TimeStamp = timeStamp;
            Value = value;
        }

        public DateTime TimeStamp { get; private set; }
        public int Value { get; private set; }
    }
}
