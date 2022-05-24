using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepsTracker
{
    internal class StepsTracker
    {
        Dictionary<DateTime, int> stepsDict;
        int days;

        public StepsTracker()
        {
            stepsDict = new Dictionary<DateTime, int>();
            days = 0;
        }

        public void addTodaysSteps(int steps)
        {
            stepsDict.Add(DateTime.Today, steps);
            days++;
            Console.WriteLine("You Have added {0} steps for {1}", steps, DateTime.Today);
        }

        public int getNumDays()
        {
            return days;
        }

        public int specificDateSteps(DateTime date)
        {
            if (stepsDict.ContainsKey(date))
            {
                return stepsDict[date];
            }
            return -1;
        }
        public double lifetimeAveSteps()
        {
            int totalSteps = 0;
            foreach(var step in stepsDict.Values)
            {
                totalSteps += step;
            }

            return (double) totalSteps / days;
        }

        public double pastWeekAveSteps()
        {
            int totalSteps = 0;
            for (int i = 0; i < 7; i++)
            {
                KeyValuePair<DateTime, int> pair = stepsDict.ElementAt(i);
                totalSteps += pair.Value;

            }

            return (double) totalSteps / 7 ;
        }

    }

    
}
