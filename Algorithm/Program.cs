using Algorithm;
using Algorithm.Sort;
using Algorithm.Technique;
using Algorithm.Text.JSON;
using Algorithm.Datastructure;

namespace Algorithm
{
    internal class Program
    {       
        public static void Init()
        {
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        }

        public static void Main()
        {
            Init();

            List<List<string>> strings = new List<List<string>>
            {
                new List<string>("1", "2", "3")
            };
        }    
    }
}
    