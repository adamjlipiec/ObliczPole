using System;

public class Kontroler
{
    private FiguraGeometryczna model;
    private Widok widok;

    public Kontroler()
    {
        model = new FiguraGeometryczna();
        widok = new Widok();
    }

    public void Uruchom()
    {
        int wybor;
        do
        {
            widok.WyswietlMenu();
            // Dodano `Convert` poniżej, aby zamienić tekstowy input na liczbę
            wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    ObliczKwadrat();
                    break;
                case 2:
                    ObliczKolo();
                    break;
                case 0:
                    Console.WriteLine("Zamykanie programu...");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                    break;
            }
        } while (wybor != 0);
    }

    private void ObliczKwadrat()
    {
        double bok = widok.PobierzDlugoscBoku();
        double pole = model.ObliczPoleKwadratu(bok);
        double obwod = model.ObliczObwodKwadratu(bok);
        widok.WyswietlWynik("Kwadrat", "Pole", pole);
        widok.WyswietlWynik("Kwadrat", "Obwód", obwod);
    }

    private void ObliczKolo()
    {
        double promien = widok.PobierzPromien();
        double pole = model.ObliczPoleKola(promien);
        double obwod = model.ObliczObwodKola(promien);
        widok.WyswietlWynik("Koło", "Pole", pole);
        widok.WyswietlWynik("Koło", "Obwód", obwod);
    }
}
