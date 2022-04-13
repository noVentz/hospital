using System;

namespace hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many grandmothers are in the queue?");
            int timeWaiting = 10;
            int peoples = Convert.ToInt32(Console.ReadLine()) * timeWaiting;
            int timeInHours = 60;
            int waitingInHours = peoples / timeInHours;
            int waitingInMinutes = peoples % timeInHours;
            Console.WriteLine("Waiting time in queue {0} hours {1} minutes", waitingInHours, waitingInMinutes);
        }
    }
}
