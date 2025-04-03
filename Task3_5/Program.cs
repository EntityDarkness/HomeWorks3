namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());

            string answer = (number % 10 == 0) ? "Число оканчивается на 0" : "Число НЕ оканчивается на 0";
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
