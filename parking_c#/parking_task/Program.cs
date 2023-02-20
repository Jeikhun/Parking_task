using System;

namespace parking_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result; //odenilecek mebleg
            Console.WriteLine("Saati daxil edin");
            int Time = int.Parse(Console.ReadLine());
            retry:
            Console.WriteLine("Transport novunu daxil edin");
            int TransportType = int.Parse(Console.ReadLine());
            if(TransportType == 1)
            {
                if(Time > 1)
                {
                    result = (Time-1)*5*1.2+5;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("odenilecek mebleg 5-azn");
                }
            }else if(TransportType == 2)
            {
                if(Time > 1)
                {
                    result = (Time-1)*6*1.215+6;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("odenilecek mebleg 6-azn");
                }
            }else if(TransportType == 3)
            {
                if(Time > 1)
                {
                    result = (Time-1)*6.5*1.25+6.5;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("odenilecek mebleg 6.5-azn");
                }
            }
            else
            {
                Console.WriteLine("Duzgun daxil edilmeyib");
                goto retry;
            }
        }
    }
}
