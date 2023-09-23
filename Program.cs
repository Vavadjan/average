namespace average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывести в консоль среднее арифметическое значение . 
            //Стоп по колличеству 10 или по коду 9999.

            int i = 0;
            int sum = 0;
            int number = 0;
            int average = 0;

            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number != 9999)
                {
                    sum = sum + number; ;
                }
                else
                {
                    break;
                }                
            }

            average = sum / i;

            Console.WriteLine(i);
        }
    }
}