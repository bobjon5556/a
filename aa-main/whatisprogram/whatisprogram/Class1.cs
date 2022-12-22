static void main(string[] args)
{
    Console.Write("원의 반지름 : ");
    int i = int.Parse(Console.ReadLine());
    double d = i * 3.14;
    Console.WriteLine(i + "둘레 =" + 2 * Math.PI * d * d + "넓이");

}
