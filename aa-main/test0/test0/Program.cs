namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                {
                    int[] a = new int[20];

                    int ran = 0;



                    Random random = new Random();



                    for (int i = 0; i < a.Length; i++)

                    {

                        a[i] = i;

                    }



                    for (int i = 0; i < a.Length; i++)

                    {

                        int temp = a[i];

                        ran = random.Next(0, 20);

                        a[i] = a[ran];

                        a[ran] = temp;

                    }


                    Console.WriteLine(a[i])



                }

                }

            }
        }
    }
