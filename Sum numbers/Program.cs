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
            int firstMultipleNumber = 3;
            int secondMultipleNumber = 5;
            randomNumber = random.Next(maxNumber);

            for (int i = 0; i <= randomNumber; i++)
            {
                if (i % firstMultipleNumber == 0 | i % secondMultipleNumber == 0)
                {
                    sumMultipleNumbers += i;
                }
            }
            Console.WriteLine(sumMultipleNumbers);
        }
    }
}