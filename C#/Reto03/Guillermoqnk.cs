/*  Statement:
 *  
 * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
 * Podrás configurar generar contraseñas con los siguientes parámetros:
 * - Longitud: Entre 8 y 16.
 * - Con o sin letras mayúsculas.
 * - Con o sin números.
 * - Con o sin símbolos.
 * (Pudiendo combinar todos estos parámetros entre ellos)
 */

using System.Text;

namespace Reto3
{
    internal class Guillermoqnk
    {
        static void Main(string[] args)
        {
            string input;

            int numberOfCharacters;

            List<int> numbersToChoose = new List<int>();

            numbersToChoose.AddRange(Enumerable.Range(97, 25).ToList());

            Console.WriteLine("Welcome to the password generator!!");

            Console.WriteLine("\nHow many characters you want your password to have? Choose a number between 8 and 16");

            input = Console.ReadLine();

            try
            {
                numberOfCharacters = Convert.ToInt32(input);

                if(!(numberOfCharacters < 16 && numberOfCharacters > 8)){

                    Console.WriteLine("That's not a valid number, the password will have 9 characters");

                    numberOfCharacters = 9;
                }
            }
            catch
            {
                Console.WriteLine("That's not a valid number, characters has been locked in 9");

                numberOfCharacters = 9;
            }

            Console.WriteLine("Do you want your password to have mayus inside?? (Y/N)");

            input = Console.ReadLine();

            while (input != "Y" && input != "N")
            {
                Console.WriteLine("That's not a valid answer, try again");

                Console.WriteLine("Do you want your password to have mayus inside?? (Y/N)");

                input = Console.ReadLine();
            }

            if(input == "Y")
            {
                numbersToChoose.AddRange(Enumerable.Range(65,25).ToList());
            }

            Console.WriteLine("Do you want your password to have numbers inside?? (Y/N)");

            input = Console.ReadLine();

            while (input != "Y" && input != "N")
            {
                Console.WriteLine("That's not a valid answer, try again");

                Console.WriteLine("Do you want your password to have numbers inside?? (Y/N)");

                input = Console.ReadLine();
            }

            if (input == "Y")
            {
                numbersToChoose.AddRange(Enumerable.Range(48, 9).ToList());
            }

            Console.WriteLine("Do you want your password to have symbols inside?? (Y/N)");

            input = Console.ReadLine();

            while (input != "Y" && input != "N")
            {
                Console.WriteLine("That's not a valid answer, try again");

                Console.WriteLine("Do you want your password to have symbols inside?? (Y/N)");

                input = Console.ReadLine();
            }

            if (input == "Y")
            {
                numbersToChoose.AddRange(Enumerable.Range(33, 14).ToList());
                numbersToChoose.AddRange(Enumerable.Range(58, 6).ToList());
                numbersToChoose.AddRange(Enumerable.Range(91, 5).ToList());
                numbersToChoose.AddRange(Enumerable.Range(123, 4).ToList());
            }

            StringBuilder output = new StringBuilder();

            for(int i = 0; i < numberOfCharacters; i++)
            {
                output.Append(Char.ConvertFromUtf32(numbersToChoose[new Random().Next(0, numbersToChoose.Count)]));
            }

            Console.WriteLine("Here you have your new password, enjoy it: {0}", output.ToString());
        }
    }
}