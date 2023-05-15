using System;

namespace Primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            while(x == true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                bool prime = false;
                bool check = false;
                number = Math.Abs(number);

                while (check == false)
                {
                    if (number < 2)
                    {
                        prime = false;
                        check = true;
                        break;
                    }

                    if (number == 2)
                    {
                        prime = true;
                        check = true;
                    }

                    if (number % 2 == 0)
                    {
                        prime = false;
                        check = true;
                    }

                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            prime = false;
                            check = true;
                            break;
                        }
                        if (i == number - 1)
                        {
                            prime = true;
                            check = true;
                            break;
                        }
                    }
                    
                }
                Console.WriteLine(prime);
                Console.WriteLine();
                Console.Write("Do you want to continue? (y/n): ");
                string answer = Console.ReadLine();
                if ("n" == answer)
                {
                    x = false;
                }
                Console.Clear();
            }
            
            
            
        }
    }
}