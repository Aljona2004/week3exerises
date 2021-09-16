using System;

namespace InsagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võib Instagram´i kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor

            Console.WriteLine("Mis aastal sa sündisid?");
            int userYearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - userYearOfBirth;

            if(userAge >=13)
            {
                Console.WriteLine("Tere tulemast Instagram´i");
            }
            else
            {
                Console.WriteLine("Oled liiga noor.");
            }
            
            
            


        }
    }
}
