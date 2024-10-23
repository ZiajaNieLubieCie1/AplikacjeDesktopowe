using System;
public class Zad5
{
    public static void Main(string[] args)
    {
        //Zad 5
        int z = 0;
        int y = -1;
        while (true)
        {
            y++;
            Console.WriteLine("Podaj liczbe: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            else
            {
                z+=x;
            }
        }
        Console.WriteLine("Suma liczb " + z);
        Console.WriteLine("Ilosc liczb " + y);
    }
}
