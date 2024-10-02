using System;
using System.Security.Cryptography.X509Certificates;

public class Program

{
    public static void Main (string[] arqs)
    {
        /*
        Console.WriteLine("Zadanie 1");
        Console.WriteLine("Podaj x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj y");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x == 0 || y == 0)
        {
            Console.WriteLine("Punkt znajduje się pośrodku czterech ćwiartek");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Punkt znajduje się w 1 ćwiartce");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Punkt znajduje się w 2 ćwiartce");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Punkt znajduje się w 3 ćwiartce");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Punkt znajduje się w 4 ćwiartce");
        }
        else
        {
            Console.WriteLine("AHA26");
        }
        Console.WriteLine("Zadanie 2");
        Console.WriteLine("Podaj długość a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj długość b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj długość c");
        int c = Convert.ToInt32(Console.ReadLine());
        if(a + b > c && a <= c && b <= c)
        {
            Console.WriteLine("Obwód: " + (a + b + c));
            Console.WriteLine("Pole: " + (0.25 * (Math.Sqrt(4 * a*a * b*b - (a*a + b*b - c*c) * (a*a + b*b - c*c)))));
        }
        else if (a + c > b && a <= b && c <= b)
        {
            Console.WriteLine("Obwód: " + (a + b + c));
            Console.WriteLine("Pole: " + (0.25 * (Math.Sqrt(4 * a * a * b * b - (a * a + b * b - c * c) * (a * a + b * b - c * c)))));
        }
        else if (b + c > a && c <= a && b <= a)
        {
            Console.WriteLine("Obwód: " + (a + b + c));
            Console.WriteLine("Pole: " + (0.25 * (Math.Sqrt(4 * a * a * b * b - (a * a + b * b - c * c) * (a * a + b * b - c * c)))));
        }
        else
        {
            Console.WriteLine("Nie może powstać z tych długości trójkąt");
        }
        */
        Console.WriteLine("Zadanie 3");
        Console.WriteLine("Podaj pesel");
        string pesel = Console.ReadLine();
        Convert.ToInt64(pesel);
        if (pesel.Length == 11)
        {
            Console.WriteLine("Pesel się zgadza");
            if (pesel[9] % 2 == 1)
            {
                Console.WriteLine("Jesteś mężczyzną");
            }
            else if (pesel[9] % 2 == 0)
            {
                Console.WriteLine("Jesteś kobietą");
            }
            Console.Write("Miesiąc ");
            if (pesel[2] == '1' && pesel[3] == '2')
            {
                Console.WriteLine("Grudzień");
            }
            if (pesel[2] == '1' && pesel[3] == '1')
            {
                Console.WriteLine("Listopad");
            }
            if (pesel[2] == '1' && pesel[3] == '0')
            {
                Console.WriteLine("Październik");
            }
            if (pesel[3] == '9')
            {
                Console.WriteLine("Wrzesień");
            }
            if (pesel[3] == '8')
            {
                Console.WriteLine("Sierpień");
            }
            if (pesel[3] == '7')
            {
                Console.WriteLine("Lipiec");
            }
            if (pesel[3] == '6')
            {
                Console.WriteLine("Czerwiec");
            }
            if (pesel[3] == '5')
            {
                Console.WriteLine("Maj");
            }
            if (pesel[3] == '4')
            {
                Console.WriteLine("Kwiecień");
            }
            if (pesel[3] == '3')
            {
                Console.WriteLine("Marzec");
            }
            if (pesel[3] == '2')
            {
                Console.WriteLine("Luty");
            }
            if (pesel[3] == '1')
            {
                Console.WriteLine("Styczeń");
            }
            else
            {
                Console.WriteLine("Nie urodziłeś się");
            }
        }
        else
        {
            Console.WriteLine("Pesel jest niepoprawny");
        }
    }
}