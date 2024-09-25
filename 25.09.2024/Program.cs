using System;
public class Program
{
    public static void Main(string[] arqs)
    {
        Console.WriteLine("Zad 1");
        Console.WriteLine("Witaj świecie!");

        Console.WriteLine("Zad 2");
        string imie = Console.ReadLine();
        Console.WriteLine("Cześć, " + imie);

        Console.WriteLine("Zad 3");
        string liczba1 = Console.ReadLine();
        string liczba2 = Console.ReadLine();


        var liczba3 = Convert.ToInt32(liczba1);
        var liczba4 = Convert.ToInt32(liczba2);
        Console.WriteLine("Wynik to: " + (liczba3 + liczba4));

        Console.WriteLine("Zad 4");
        var liczba5 = Console.ReadLine();
        var promien = Convert.ToDouble(liczba5);
        Console.WriteLine("Powierzchnia koła wynosi: " + (3.14 * Math.Pow(promien, 2)));

        Console.WriteLine("Zad 5");
        var TempC = Console.ReadLine();
        var TempC2 = Convert.ToDouble(TempC);
        Console.WriteLine("Stopnie Fahrenheita: " + ((TempC2 * 9 / 5) + 32));

        Console.WriteLine("Zad 6");
        int liczba6 = int.Parse(Console.ReadLine());
        string ciągZ = Convert.ToString(liczba6);
        Console.WriteLine(ciągZ);

        Console.WriteLine("Zad 7");
        double liczba7 = int.Parse(Console.ReadLine());
        double liczba8 = int.Parse(Console.ReadLine());
        Console.WriteLine("Średnia tych liczb to: " + ((liczba7 + liczba8) / 2));

        Console.WriteLine("Zad 8");
        var liczba9 = Console.ReadLine();
        var liczba10 = Convert.ToInt32(liczba9);
        Console.WriteLine("Kwadrat podanej liczby to: " + Math.Pow(liczba10, 2));

        Console.WriteLine("Zad 9");
        double liczba11 = int.Parse(Console.ReadLine());
        int liczba12 = Convert.ToInt32(liczba11);
        Console.WriteLine("Wynik: " + liczba12);

    }
}
