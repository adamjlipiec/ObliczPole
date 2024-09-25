# ObliczPole

 Opis projektu
**ObliczPole** to aplikacja konsolowa napisana w języku C# z użyciem architektury MVC (Model-View-Controller). Aplikacja umożliwia użytkownikowi obliczanie pól i obwodów różnych figur geometrycznych, takich jak kwadrat i koło.

 Funkcjonalności
- Obliczanie pola kwadratu.
- Obliczanie obwodu kwadratu.
- Obliczanie pola koła.
- Obliczanie obwodu koła.
- Prosty interfejs użytkownika działający w konsoli.
- Możliwość rozbudowy o dodatkowe figury geometryczne i funkcje.

 Wymagania
Aby uruchomić projekt, potrzebujesz:
- **.NET 6.0 SDK** lub wyższy
- **Visual Studio 2019/2022** lub nowszy, bądź dowolne inne środowisko wspierające .NET 6.0

Instrukcja użytkowania

    Po uruchomieniu aplikacji w konsoli pojawi się menu:

    Wybierz figurę geometryczną:
    1. Kwadrat
    2. Koło
    0. Wyjdź

    Wybierz opcję z menu, wpisując odpowiednią liczbę:
        1 dla kwadratu
        2 dla koła
        0 aby wyjść z aplikacji

    Następnie podaj dane (np. długość boku kwadratu lub promień koła).
    Wynik obliczeń zostanie wyświetlony w konsoli.

Struktura projektu

    Models: Zawiera logikę obliczeń dla figur geometrycznych (klasa FiguraGeometryczna).
    Controllers: Obsługuje interakcje między modelem a widokiem (klasa Kontroler).
    Views: Zajmuje się wyświetlaniem menu i wyników w konsoli (klasa Widok).
    Program.cs: Punkt wejściowy aplikacji, uruchamia kontroler.


Autor

    Imię i nazwisko: Adam Lipiec
    Nr indeksu: 19446