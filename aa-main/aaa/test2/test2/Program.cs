namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.Write("원의 반지름 : ");
                int i = int.Parse(Console.ReadLine());
                double d = i;
                Console.WriteLine("겉넓이=" + 4 * Math.PI * i*i + ", 부피="+4/3 * Math.PI * i*i*i);

            }
        }
    }
}