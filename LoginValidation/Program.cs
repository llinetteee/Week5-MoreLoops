using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i < 3)

            {
                Console.WriteLine("Sisesta kasutajatunnus: ");

                string userName = Console.ReadLine();

                Console.WriteLine("Sisesta salasõna: ");

                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                    
                }

                else

                {

                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti");


                }

                if(i== 3)

                {
                    Console.WriteLine("Oled 3 korda sisestanud valesti kas kasutajasõna või parooli.");
                }

            }
        }

    }
}