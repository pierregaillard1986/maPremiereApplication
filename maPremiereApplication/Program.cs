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
            //Exercice 1
            //String prenom = Environment.UserName;
            //String direBonjour = "Bonjour" + " " + prenom;
            //String direAurevoir = "Bonsoir" + " " + prenom;
            //String direBonWeekEnd = "Bon week-end" + " " + prenom;
            //String day = DateTime.Now.DayOfWeek.ToString();
            //int hour = DateTime.Now.Hour;
            //if (day == "Sunday" || day == "Saturday" || (day == "Friday" && hour >= 18) || (day == "Monday" && hour < 9))
            //{
            //    Console.WriteLine(direBonWeekEnd);
            //}
            //else
            //{
            //    if (hour < 9 || hour > 18)
            //        Console.WriteLine(direAurevoir);
            //    else
            //        Console.WriteLine(direBonjour); 
            //}
            //Exercice 2
            Console.WriteLine(Calcul(1, 10));
            Console.WriteLine(Calcul(1, 100));

            //Exercice 3
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            Console.WriteLine(CalculMoyenne(liste));
            
            //Exercice 4
        }
        //Exercice 2
        static int Calcul(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
        //Exercice 3
        static double CalculMoyenne(List<double> a)
        {
            double sum = 0.0;
            for (int i = 0; i< a.Count; i++)
            {
                sum += a[i];
            }
            return sum/a.Count;
        }
        //Exercice 4

    }
}
