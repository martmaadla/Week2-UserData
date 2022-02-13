using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada"
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada"
            //Kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne" Nüüd saad juhilube taodelda"

            Console.WriteLine("Palun, sisesta oma sünnniaasta (numbritega): ");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2022 - YearOfBirth;
            
            if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne 2022. aastal saad juhilube taodelda.");
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
