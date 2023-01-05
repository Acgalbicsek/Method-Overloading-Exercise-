using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
     public static int Add(int x, int y)

        { return x + y; }

        

     public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

     public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
            

        } 

        static void Main(string[] args)
        {
            Add(7, 27);
            var result = Add(2,2);
            Console.WriteLine(result);

            Add(2.0m,2.0m);
            var answer = Add(2.4m, 2.7m);
            Console.WriteLine(answer);

            Add(4,8,true);
            var sum = Add(1, 0, true);
            Console.WriteLine(sum);



        }
    }
}
