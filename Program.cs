using System;

//Napisz program, który umożliwia odczytywanie długości łańcucha zapamiętanego w odpowiedniej zmiennej.
//Program powinien mierzyć długość łańcucha nazwa miasta i województwo. Użytkownik podaje nazwę miasta i województwo.
//Skorzystaj z metody Length, a wynik wyświetl w postaci
//np. "Nazwa miasta Warszawa zawiera 8 liter. Nazwa województwa Mazowieckie zawiera 11 liter."

class MetodaLength
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwę miasta: ");
        string nazwaMiasta = Console.ReadLine();

        Console.WriteLine("Podaj nazwę województwa: ");
        string nazwaWojewodztwa = Console.ReadLine();

        int dlugoscMiasta = nazwaMiasta.Length;
        int dlugoscWojewodztwa = nazwaWojewodztwa.Length;

        Console.WriteLine($"Nazwa miasta {nazwaMiasta} zawiera {dlugoscMiasta} liter.");
        Console.WriteLine($"Nazwa województwa {nazwaWojewodztwa} zawiera {dlugoscWojewodztwa} liter");
    }
}