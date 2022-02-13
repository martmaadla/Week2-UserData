using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaastat;
            //Programm kuvab sünniaastat konsooli
            //Oled sündinud aastal {YearOfBirth};

            Console.WriteLine("Palun, sisesta oma vanus (numbritega): ");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - UserAge;

            Console.WriteLine($"Sa oled sündinud {YearOfBirth} aastal.");

        }
    }
}
