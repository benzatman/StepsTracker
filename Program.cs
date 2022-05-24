using System;

namespace StepsTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StepsTracker st = new StepsTracker();
            st.addTodaysSteps(13364);
            double num = st.lifetimeAveSteps();
            Console.WriteLine("Your have taken on average {0} steps per day since activation", num);
        }
    }
}
