namespace FizzBuzz
{
    class Program
    {
        static string? GetNum()
        {
            return Console.ReadLine();
        }
        static bool IsNumThere(string? num)
        {
            if (num == null || num == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool IsNumeric(string? num)
        {
            int i = 0;
            int numLength = num.Length - 1;
            do
            {
                if (Char.IsNumber(num, i))
                {
                    return true;
                }
                i++;
            }
            while (numLength >= i);
            return false;
        }
        static bool IsNumLetter(string? num)
        {
            int i = 0;
            int numLength = num.Length - 1;
            do
            {
                if (Char.IsLetter(num, i))
                {
                    return true;
                }
                i++;
            }
            while (numLength >= i);
            return false;
        }
        static string? ValidateNum()
        {
            bool numIsThere = false;
            bool numIsNum = false;
            bool numIsLetter = true;
            string? num;

            do
            {
                num = GetNum();
                numIsThere = IsNumThere(num);

                if (!numIsThere)
                {
                    Console.Write("Nothing was entered.\nPlease pick a number: ");
                    continue;
                }

                numIsNum = IsNumeric(num);
                numIsLetter = IsNumLetter(num);

                if (!numIsNum || numIsLetter)
                {
                    Console.Write("Something other than a number was entered.\nPlease pick a number: ");
                    continue;
                }
            }
            while (!numIsThere || !numIsNum || numIsLetter);

            return num;
        }
        static void FizzedAndBuzzed(string? num)
        {
            int i = 1;

            do
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write("Fizz! ");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.Write("Buzz! ");
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("FizzBuzz! ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
            while (i <= Convert.ToDouble(num));
        }
        static void Main(string[] args)
        {
            Console.Write("Please choose a number to FizzBuzz: ");

            string? numIsValid = ValidateNum();

            FizzedAndBuzzed(numIsValid);

            Console.Write($"\nYou've sucessfully FizzBuzzed the number {numIsValid}.");
        }
    }
}