namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, guys!");

            Console.WriteLine("Hello from Ilia");
            Console.WriteLine("Wtasaaaaaaaaaaaaaaaap!");
            int[] arr = { 23, 45, 8, 4, 32, 10 };
            int countEven = 0, countOdd = 0, sumEven = 0, sumOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                    sumEven += arr[i];
                }
                else
                {
                    countOdd++;
                    sumOdd += arr[i];
                }
            }
            Console.WriteLine($"Count of even numbers equals {countEven} and their sum equals {sumEven}");
            Console.WriteLine($"Count of odd numbers equals {countOdd} and their sum equals {sumOdd}");
        }
    }
}