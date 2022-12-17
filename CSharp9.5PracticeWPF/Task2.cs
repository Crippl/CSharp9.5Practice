using static System.Console;

namespace Task2
{
    public class Task2
    {
        public static void MainTask2(string[] args)
        {
            WriteLine("Введите предложение (разделите слова пробелами) : ");
            WriteLine(Reverse(ReadLine()));
        }

        /// <summary>
        /// Метод, разворачивабщий порядок слов в предложении
        /// </summary>
        /// <param name="inputPhrase"></param>
        public static string Reverse(string inputPhrase)
        {
            string resultString=null;
            for (int i = SplitText(inputPhrase).Length-1; i >=0; i--)
            {
                resultString += SplitText(inputPhrase)[i] + " ";
            }
            return resultString;
        }

        /// <summary>
        /// Метод, разделяющий введённый текст на слова
        /// </summary>
        /// <param name="enteredText"></param>
        /// <returns></returns>
        public static string[] SplitText(string enteredText)
        {
            return enteredText.Split(' ');
        }
    }
}
