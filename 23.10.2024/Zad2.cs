using System;
public class Zad2
{
    public static void Main(string[] args)
    {
        //Zad 2
        Console.Write("Podaj poczatek zakresu w stopniach Celsjusza: ");
        int poczatek = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj koniec zakresu w stopniach Celsjusza: ");
        int koniec = Convert.ToInt32(Console.ReadLine());
        while(poczatek <= koniec)
        {

            Console.Write(poczatek + " Celsjusza to ");
            poczatek++;
            Console.WriteLine(poczatek * (9/5) + 32 + " Fahrenheita ");
            
        }
    }
}
