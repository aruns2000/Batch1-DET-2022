using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class ParamsDemo
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;


        }
        public static void Main()
        {
            int x;
            try
            {
                Console.WriteLine("enter a number");
                x = int.Parse(Console.ReadLine());


                Console.WriteLine(Sum(1, 1, 3, x));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry, Error occured please contact admin");
                //Console.WriteLine(ex.Source);
            }
            finally
            {
                Console.WriteLine("Thanks for using sum function");
            }
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Sum(a));
            
        }
    }
}