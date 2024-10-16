using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Zad 1
        Console.WriteLine("Zad 1");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i + " ");
        }

        //Zad 2
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Zad 2");
        for (int i = 100; i >= 50; --i)
        {
            Console.Write(i + " ");
        }

        //Zad 3
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Zad 3");
        Console.WriteLine("Podaj Liczbe");
        int y = 0;
        int a = 0;
        for (; ; a++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            else
            {
                y += x;
            }
        }
        Console.WriteLine("Suma liczb: " + y);
        Console.WriteLine("Ilosc liczb: " + a);

        //Zad 4
        Console.WriteLine(" ");
        Console.WriteLine("Zad 4");
        Console.WriteLine("Podaj poczatek przedzialu: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj koniec przedzialu: ");
        int k = Convert.ToInt32(Console.ReadLine());
        if(p < k)
        {
            for(; p <= k; p++)
            {
                if(p % 3 == 0)
                {
                    Console.Write(p + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Bład podane zle liczby");
        }
        
        //Zad 5
        Console.WriteLine(" ");
        Console.WriteLine("Zad 5");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Convert.ToString(b, 2));

        //Zad 6
        Console.WriteLine(" ");
        Console.WriteLine("Zad 6");
        int g = Convert.ToInt32(Console.ReadLine());
        for (; g>= 0; g--)
        {
            for(int t = 1; t <= g; t++)
            {
                    Console.Write("*");
            }
            Console.WriteLine(" ");
        }

    }
}