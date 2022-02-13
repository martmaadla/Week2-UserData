using System;

namespace InstagaramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust
            //Programm kontrollib kas kasutaja on vanem kui 13 aastat või 13 aastat vana;
            //Kui kastaja on 13 aastat vana või vanem , siis võib intagrammi kastada
            //Kui kasta on noorem kui 13, siis on ta veel liiga noor.

            Console.WriteLine("Palun, sisesta oma vanus (numbritega): ");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if (UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et kasutada Instagrammi.");
             }
            else if(UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et kasutada Instagrammi.");
             }
            else            
            {
                Console.WriteLine("Oledki 13 ja saad kasutada Instagrammi.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
