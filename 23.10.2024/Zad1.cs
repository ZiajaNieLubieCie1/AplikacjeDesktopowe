using System;
public class Zad1
{
    public static void Main(string[] args)
    {
        //Zad 1
        while (true)
        {
            Console.Write("Podaj liczbe zakresu: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int z = 1;
            if (x > z)
            {
                while (z <= x)
                {
                    if (z % 2 == 1)
                    {
                        Console.Write(z + " ");
                    }
                    z++;   
                }
                break;
            }
            else
            {
                Console.WriteLine("Blad");
                continue;
            }
        }
        
    }
}
