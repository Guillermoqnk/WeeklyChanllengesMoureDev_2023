/*  Statement:
 * 
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 */

namespace Reto1;
class Program
{
    private static Dictionary<char, char> leetLanguage = new Dictionary<char, char>()
    {
        { '0', 'o' },
        { '1', 'L' },
        { '2', 'R' },
        { '3', 'E'},
        { '4', 'A' },
        { '5', 'S' },
        { '6', 'b' },
        { '7', 'T' },
        { '8', 'B' },
        { '9', 'g' },
    };

    static void Main(string[] args)
    {

        Console.WriteLine("Introduce the text to translate: ");

        var input = Console.ReadLine();

        Console.WriteLine(TransformToLeet(input));
    }

    private static string TransformToLeet(string input)
    {
        foreach (var translation in leetLanguage)
        {
            input = input.Replace(translation.Key, translation.Value);
        }

        return input;
    }
}
