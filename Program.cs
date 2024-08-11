using System.Text.RegularExpressions;

namespace BasicRecursion
{
    internal class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            //Print();
            //PrintName(1, 5);
            //PrintNumber(1, 10);
            //PrintNumberReverse(5, 5);
            //PrintNumber2(5, 5);
            //PrintNumberReverse2(5, 5);
            //SumofN(3, 0);
            //Console.WriteLine(SumofN2(3));
            //Console.WriteLine(FactorialofN(5));
            //int[] a = { 1, 4, 3, 2, 5, 9 };
            //ReverseArray(a);
            //ReverseArrayRecursion(0, a, a.Length);
            //Console.WriteLine(CheckStringPalindrome(0, "raceecar"));
            Console.WriteLine(FibonacciNumber(4));
        }


        static int FibonacciNumber(int n)
        {
            if (n <= 1)
                return n;

            int last = FibonacciNumber(n - 1);
            int slast = FibonacciNumber(n - 2);

            return last + slast;
        }

        static bool CheckStringPalindrome(int i, string s)
        {
            if(i >= s.Length/2)
                return true;

            if (s[i] != s[s.Length - i - 1])
                return false;

            return CheckStringPalindrome(i+1, s);
        }

        static void ReverseArrayRecursion(int i, int[] a, int n)
        {
            if(i >= n/2)
            {
                foreach (var item in a)
                    Console.WriteLine(item);
                return;
            }
         
           
            int temp = a[i];
            a[i] = a[n - i - 1];
            a[n - i - 1] = temp;
            ReverseArrayRecursion(i+1, a, n);
        }


        static void ReverseArray(int[] array)
        {
            int length = array.Length;
            for(int i = 0; i <= array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }

            for(int i = 0;i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static int FactorialofN(int n)
        {
            if(n == 0)
                return 1;

            return n * FactorialofN(n - 1);
        }

        static int SumofN2(int n)
        {
            if(n == 0)
                return 0;

            return n + SumofN2(n-1);

        }

        //Parameterised Recursion
        static void SumofN(int i, int sum)
        {
            if(i < 1)
            {
                Console.WriteLine(sum);
                return;
            }

            SumofN(i-1, sum + i);
        }

        static void PrintNumberReverse2(int i, int n)
        {
            if (n < 1)
                return;

            Console.WriteLine(n);
            PrintNumberReverse2(i, n-1);
        }

        static void PrintNumber2(int i, int n)
        {
            if(i < 1)
                return;

            PrintNumber2(i-1, n);
            Console.WriteLine(i);
        }

        static void PrintNumberReverse(int i, int n)
        {
            if (i < 1)
                return;

            Console.WriteLine(i);
            PrintNumberReverse(i-1, n);
        }

        static void PrintNumber(int i, int n)
        {
            if (i > n)
                return;

            Console.WriteLine(i);
            PrintNumber(i + 1, n);
        }

        static void PrintName(int i, int n)
        {
            if (i > n) 
                return;

            Console.WriteLine("Sushil");
            PrintName(i + 1, n);
        }

        static void Print() 
        {
            if (count == 3)
                return;

            Console.WriteLine(count);
            count++;
            Print();
        
        }
    }
}