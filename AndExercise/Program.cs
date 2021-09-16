using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            // programm küsib kasutajal sisestada tema
            //ekasmi punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta matemaatika eksami punktid:");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta keemia eksami punktid:");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta bioloogia eksami punktid:");
            int math = Convert.ToInt32(Console.ReadLine());

            if(math > 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("tubli töö! Õpi arstiks!");
            }
            else
            {
                Console.WriteLine("Ei ole piisavalt punkte.");
            }

        }
    }
}
