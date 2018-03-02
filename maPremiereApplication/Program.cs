using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maPremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String prenom = Environment.UserName;
            String direBonjour = "Bonjour" + " " + prenom;
            String direAurevoir = "Bonsoir" + " " + prenom;
            String direBonWeekEnd = "Bon week-end" + " " + prenom;
            String day = DateTime.Now.DayOfWeek.ToString();
            int hour = DateTime.Now.Hour;
            if (day == "Sunday" || day == "Saturday" || (day == "Friday" && hour >= 18) || (day == "Monday" && hour < 9))
            {
                Console.WriteLine(direBonWeekEnd);
            }
            else
            {
                if (hour < 9 || hour > 18)
                    Console.WriteLine(direAurevoir);
                else
                    Console.WriteLine(direBonjour);
            }
        }
    }
}
