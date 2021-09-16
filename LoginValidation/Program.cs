using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestada kasutajatunnust ja parool
            //programm konrtollib sisestatud andmed
            //kui sisestadud kasutaja tunnus on "admin" ja
            //sisestadud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //muul juhul programm kuvab "Vale kasutaja tunnus või parool. Proovi uuesti";

            Console.WriteLine("Sisesta oma kasutajatunnus ja parool:");
            string userName = Console.ReadLine();
            string passWord = Console.ReadLine();

            /*if (userName == "admin" && passWord == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }  */
            if (userName != "admin" || passWord != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uusesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
             
        }
    }
}
