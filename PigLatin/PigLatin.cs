using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piglatin
{
    class getPigLatin
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Text To Convert");
                string UserInputText = Console.ReadLine().ToUpper();
                Console.WriteLine("Text = " + UserInputText);
                List<char> array = new List<char>();
                List<char> Alphabet = new List<char>()
        {
            'B', 'C', 'Ç', 'D', 'F', 'G', 'H', 'J',
             'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'Y', 'X','Z', 'W'
        };
                List<char> consonants = new List<char>()
        {
            'A', 'E', 'I', 'O', 'U'
        };
                for (int i = 0; i < UserInputText.Length; i++)
                {
                    array.Add(UserInputText[i]);
                }
                if (Alphabet.Contains(array[0]) && consonants.Contains(array[1]))
                {
                    var newPos = array[0];
                    array.Remove(newPos);
                    array.Add(newPos);
                    TheTextOutPut(array);
                    for (int J = 0; J < array.Count; J++)
                    {
                        Console.Write(array[J]);
                    }
                }
                else if (Alphabet.Contains(array[0]) && Alphabet.Contains(array[1]))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var newPos = array[0];
                        array.Remove(newPos);
                        array.Add(newPos);
                    }
                    TheTextOutPut(array);
                    for (int J = 0; J < array.Count; J++)
                    {
                        Console.Write(array[J]);
                    }
                }
                else if (consonants.Contains(array[0]))
                {
                    TheTextOutPut(array);
                    for (int J = 0; J < array.Count; J++)
                    {
                        Console.Write(array[J]);
                    }
                }
                Console.WriteLine("\nPress Enter To Continue");
                Console.ReadKey();
            }
        }
        private static void TheTextOutPut(List<char> array)
        {
            for (int i = 0; i < 1; i++)
            {
                array.Add('A');
                array.Add('Y');
            }
        }

        private static void TheTextOutPut2(List<char> array)
        {
            for (int i = 0; i < 1; i++)
            {
                array.Add('Y');
                array.Add('A');
                array.Add('Y');
            }
        }
    }
}