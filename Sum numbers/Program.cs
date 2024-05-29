namespace Sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumber = 101;
            int randomNumber;
            int sumMultipleNumbers = 0;
            int multipleNumber1 = 3;
            int multipleNumber2 = 5;
            randomNumber = random.Next(maxNumber);

            for (int i = 0; i <= randomNumber; i++)
            {
                if (i % multipleNumber1 == 0 | i % multipleNumber2 == 0)
                {
                    sumMultipleNumbers += i;
                }
            }
            Console.WriteLine(sumMultipleNumbers);
        }
    }
}