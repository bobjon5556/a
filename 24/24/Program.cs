using System;

public static class Globals
{

    public static void changeLocation(int dest, int sour, int[] arr)
    {
        int temp = arr[dest];
        arr[dest] = arr[sour];
        arr[sour] = temp;
    }

    internal static void Main()
    {

        int locationZero = 24;
        int[] arr = new int[25];

        for (int i = 0; i < 24; i++)
        {
            arr[i] = i + 1;
        }

        for (int i = 0; i < 77; i++)
        {
            int dest = 0;
            int sour = 0;
            int temp = 0;



            changeLocation(dest, sour, arr);

        }
        arr[24] = 0;

        while (true)
        {

            int locationZeroNow = locationZero;

            for (int i = 0; i < 25; i++)
            {
                Console.Write(arr[i]);
                Console.Write('\t');
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("\n");
                    Console.Write("\n");
                }
            }

            string key = Console.ReadLine();



            switch (key)
            {
                case "w":
                    if (locationZero < 5)
                    {
                        break;
                    }
                    locationZero -= 5;
                    break;
                case "a":
                    if (locationZero % 5 == 0)
                    {
                        break;
                    }
                    locationZero -= 1;
                    break;
                case "d":
                    if (locationZero % 5 == 4)
                    {
                        break;
                    }
                    locationZero += 1;
                    break;
                case "s":
                    if (locationZero > 19)
                    {
                        break;
                    }
                    locationZero += 5;
                    break;

                default:
                    continue;
            }

            {
                int dest = locationZeroNow;
                int sour = locationZero;
                changeLocation(dest, sour, arr);
            }

        }
    }
}
