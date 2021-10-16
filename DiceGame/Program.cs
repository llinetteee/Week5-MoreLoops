using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus oslleb 2 mängijat - arvuti CPU ja kasutaja ehk user;
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //kes viskas rohkem on võitja;
            //täringuid visatakse 3 korda;
            //programm kuulutab võitja, kas arvuti või kasutaja;

            
            for (int i = 0; i < 3; i++)
            {

                Random rnd = new Random();

                int CpuRandom = rnd.Next(1, 7);

                int userRandom = rnd.Next(1, 7);

                int CpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Arvuti viskas {CpuRandom}. Kasutaja viskas {userRandom}");


                if (CpuRandom < userRandom)
                {

                     Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;

                }
                else if(CpuRandom > userRandom)
                {

                    Console.WriteLine("Arvuti on mängu võitnud. Palju õnne!");
                    CpuScore = CpuScore + 1;

                }
                else
                {

                    Console.WriteLine("VIIK!");

                }

                
            }
        }
    }
}