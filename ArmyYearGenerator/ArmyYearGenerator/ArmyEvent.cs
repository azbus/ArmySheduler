using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ArmyYearGenerator
{
    [Serializable]
    public class ArmyEvent
    {
        string name;
        string theme;
        string[] dayOfWeek;
        DateTime startTime;
        DateTime endTime;

        public ArmyEvent(string name, string[] days, DateTime startTime, DateTime endTime)
        {
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;

            this.dayOfWeek = (string[])days.Clone();
        }

        public string getName()
        {
            return name;
        }

        public DateTime getStartTime()
        {
            return startTime;
        }
        public DateTime getEndTime()
        {
            return endTime;
        }

        public string[] getDays()
        {
            return dayOfWeek;
        }

    }
}
