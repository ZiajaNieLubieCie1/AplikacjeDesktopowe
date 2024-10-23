using System;
public class Zad8
{
    public static void Main(string[] args)
    {
        //Zad 8
        int z = 1;
        int y = -1;
        while (true)
        {
            y++;
            Console.WriteLine("Podaj liczbe: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                break;
            }
            else
            {
                z *= x;
            }
        }
        Console.WriteLine("Iloczyn liczb " + z);
        Console.WriteLine("Ilosc liczb " + y);
    }
}
