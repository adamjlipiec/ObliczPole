// Model: Definiuje logikę obliczeniową

using System;
public class FiguraGeometryczna
{
    // Oblicza pole kwadratu
    public double ObliczPoleKwadratu(double bok)
    {
        return bok * bok;
    }

    // Oblicza obwód kwadratu
    public double ObliczObwodKwadratu(double bok)
    {
        return 4 * bok;
    }

    // Oblicza pole koła
    public double ObliczPoleKola(double promien)
    {
        return Math.PI * promien * promien;
    }

    // Oblicza obwód koła
    public double ObliczObwodKola(double promien)
    {
        return 2 * Math.PI * promien;
    }
}
