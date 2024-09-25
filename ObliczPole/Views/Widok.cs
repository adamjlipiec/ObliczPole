// Widok: Zajmuje się interakcją z użytkownikiem

using System;
public class Widok
{
    // Wyświetla menu
    public void WyswietlMenu()
    {
        Console.WriteLine("Wybierz figurę geometryczną:");
        Console.WriteLine("1. Kwadrat");
        Console.WriteLine("2. Koło");
        Console.WriteLine("0. Wyjdź");
    }

    // Pobiera od użytkownika dane dotyczące kwadratu
    public double PobierzDlugoscBoku()
    {
        Console.Write("Podaj długość boku kwadratu: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    // Pobiera od użytkownika dane dotyczące koła
    public double PobierzPromien()
    {
        Console.Write("Podaj promień koła: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    // Wyświetla wynik obliczeń
    public void WyswietlWynik(string figura, string typObliczen, double wynik)
    {
        Console.WriteLine($"Wynik obliczeń dla {figura} ({typObliczen}): {wynik}");
    }
}
