using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust;
            //Programm kuvab kasutaja vanuse konsoolis;

            Console.WriteLine("Palun, sisesta oma sünnniaasta (numbritega): ");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2022 - YearOfBirth;

            //Console.WriteLine("Oled " + UserAge + " aastat vana.");
            Console.WriteLine($"Sellel aastal saad {UserAge} aastat vanaks.");

        }
    }
}
