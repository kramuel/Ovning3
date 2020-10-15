using System;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Övning 3:0
Skriv ett program som skriver ut alla udda tal mellan 625 och upp till och med 767.
            */

            /*!!!!
            for (int i = 625; i <= 767; i++)
            {
                Console.WriteLine(i);
            }
            !!!!*/

            /*
            Övning 3:1
Skriv ut alla tal, från och med 0 till och med 1000, som är delbara med 3 och 7.
            */

            /*!!!!!!
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            !!!!!!!!!!*/

            /*
            Övning 3:2
Skriv ett program som frågar användaren efter ett godtyckligt heltal. Programmet ska
sedan meddela användaren om talet är delbart med 9.
             */

            /*!!!!!!
            Console.WriteLine("Ge mig ett heltal: ");

            int x = int.Parse(Console.ReadLine());
            
            if (x % 9 == 0)
            {
                Console.WriteLine("{0} är delbart med 9", x);
            }
            else
            {
                Console.WriteLine("{0} är inte delbart med 9 din dumma jävel :)", x)
            }
            
            !!!!!*/

            /*
             Övning 3:3
Skriv ett program som beräknar summan av de första hundra heltalen.
             */

            /*!!!!!!!!
            int x = 0;

            for (int i = 1; i <= 100; i++)
            {
                x += i;
                //Console.Write("{0}  ", x);
            }
            Console.WriteLine(x);
            !!!!!!!*/


            /*Övning 3:4
Utgå från övning 3:3 och låt användaren ange mellan vilka två tal programmet ska räkna
summan.
            */

            /*!!!!!!!!!!!
            Console.WriteLine("Ge 2 tal så fixar jag summan mellan alla de talen(a<b): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int x = 0;
            for (int i = a; i <= b; i++)
            {
                x += i;
                //Console.Write("{0}  ", x);
            }
            Console.WriteLine(x);
            !!!!!!!!!!*/




            Console.ReadKey();
        }
    }
}
