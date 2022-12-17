using static System.Console;

namespace Task1
{
    public class Task1
    {
        public static void MainTask1(string[] args)
        {
            WriteLine("Введите предложение (разделите слова пробелами) : ");
            ShowSplittedText(SplitText(ReadLine()));
        }

        /// <summary>
        /// Метод, выводящий в консоль результат разделения на слова
        /// </summary>
        /// <param name="someText"></param>
        public static void ShowSplittedText(string[] someWords)
        {
            foreach (string word in someWords)
            {
                WriteLine($" {word} ");
            }
        }

        /// <summary>
        /// Метод, разделяющий введённый текст на слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string[] SplitText(string enteredText)
        {
            return enteredText.Split(' ');
        }
    }
}
