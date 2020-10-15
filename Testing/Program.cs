using System;
using System.Linq;

namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Testing!");
            
        }
        public static int CloserToZero(int[] array)
        {
            if (array.Length == 0)
            {
                new ArgumentException();
            }
            Array.Sort(array);
            var arrDisct = array.Distinct().ToArray();
            int seed = 1;

            for (int i = 0; i < arrDisct.Length; i++)
            {
                if (arrDisct[i] <= 0)
                {
                    continue;
                }
                else if(arrDisct[i] == seed)
                {
                    seed++;
                }
            }
            return seed;
        }

        public static int CloserToZero_byLambda(int[] array)
        {
            int flag = 1;

            array = array.OrderBy(x => x).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    continue;
                }
                else if (array[i] == flag)
                {
                    flag++;
                }
            }

            return flag;
        }
    }
}
