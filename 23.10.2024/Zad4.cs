using System;
public class Zad4
{
    public static void Main(string[] args)
    {
        //Zad 4
        Console.Write("Podaj wysokosc trojkata: ");
        int h = Convert.ToInt32(Console.ReadLine());
        while(h >= 1)
        {   
            for(int x = 1; h>x ;x++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            h--;
        }
    }
}
