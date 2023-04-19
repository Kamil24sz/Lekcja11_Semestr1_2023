using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lekcja11_Semestr1_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TABLICE - służą do przechowywania wielu zmiennych, elementów

            //1.DEKLARACJA TABLIC

            int a = 13;
            int b = 40;

            //dłuższy zapis deklaracji tablicy
            int[] tablica = new int[] {1,3,5,3,a,4,5,3};

            //krótszy zapis deklaracji tablicy
            int[] tablica2 = {1,2,4,5,62,32,1,b,3,45};

            //możemy wpisywać zmienne do tablic
            int[] tablica3 = {a, b };

            //2.ODCZYT DANYCH Z TABLIC
            //tablice są numerowane od 0, aby dostać się do ich elementów używamy indexów 

            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(tablica[i]);
            }


            //Ćwiczenie 1 
            //A. Stworzyć program konsolowy, w którym należy dodać tablicę 7 elementową,
            //jako elementy należy dodać tytuły ulubionych gier i wyświetlić w konsoli każdy
            //element.

            Console.Clear();

            string[] gry = { "Frotnite", "Cs: Go", "Farcry 1", "Farcry 2", "Farcry 3", "Fifa 2023", "F1", "Sims 4" };

            //każda tablica posiada właściwość Length, która wskazuje wielkość tablicy (ilość elementów)
            Console.WriteLine("Oto Twoja kolekcja gier:");
            for(int i = 0; i < gry.Length; i++)
            {
                Console.WriteLine($"{i+1}.{gry[i]}");
            }
            
            //Zmodyfikuj program aby wylosował grę na wieczór.
            Console.WriteLine("Twoja wylosowana gra to:");

            //deklarujemy generator liczb losowych
            Random liczbaLosowa = new Random();
            //losujemy liczbę z zakresu 0 - rozmiar tablicy i zapisujemy te liczbę w zmiennej index
            int index = liczbaLosowa.Next(0, gry.Length);

            //używamy zmiennej index do wybrania gry z tablicy
            Console.WriteLine(gry[index]);


            //Ćwiczenie 2
            // Mamy 10 uczestników zawodów i chcemy wypisać ich średnią wieku,
            // dane o wieku są przechowywane w tablicy
            Console.Clear();

            int[] uczestnicy = {21, 34, 43, 21, 22, 34, 23, 67, 43, 27};

            double wynik = 0;
            for (int i = 0; i < uczestnicy.Length; i++)
            {
                wynik = wynik + uczestnicy[i];
            }
            wynik = wynik / uczestnicy.Length;
            Console.WriteLine($"Średnia wieku uczestnikó wynosi {wynik} lat");

            //Ćwiczenie 3
            //Napisać program w konsoli, który znajdzie największą wartość w tablicy i wypisze ją
            //w konsoli. Można wykorzystać tablicę uczestnicy z zadania 2.

            //zmienna pomocnicza, przypisujemy do niej pierwszy element tablicy
            int max = uczestnicy[0];
            int min = uczestnicy[0];

            //pętla for, która przejdzie po każdym elemencie
            for (int i = 0;i < uczestnicy.Length; i++)
            {
                if(max < uczestnicy[i])
                {
                    max = uczestnicy[i];
                }

                if(min > uczestnicy[i])
                {
                    min = uczestnicy[i];
                }
            }
            //Rozszerzenie - wypisz najmniejszą liczbę z tej tablicy 
            Console.WriteLine($"Maksymalna liczba tej tablicy to: {max}");
            Console.WriteLine($"Minimalna liczba tej tablicy to: {min}");

            Console.Clear();
            //Pętla FOREACH

            //tworzymy tablicę typu string z kilkoma nazwami produktów spożywczych
            string[] torbaNaZupy = {"melko", "masło", "ser", "pomidor"};

            //deklarujemy pętle
            // typ elementu musi być zgodny z typem naszej tablicy
            foreach (string produkt in torbaNaZupy)
            {
                Console.WriteLine(produkt);
            }


            //Ćwiczenie 4 
            //Przerób program z ćwiczenia nr 2, tak żeby wykorzystywało pętlę foreach zamiast
            //for.


            //for (int i = 0; i < uczestnicy.Length; i++)
            //{
            //    wynik = wynik + uczestnicy[i];
            //}

            wynik = 0;
            foreach (int x in uczestnicy)
            {
                wynik = wynik + x;
            }
            Console.WriteLine($"Średnia wieku uczestników to {wynik / 10}");

            Console.Clear();

            //Ćwiczenie 5
            //Napisać program konsolowy, który symuluje system rezerwacji biletów do kina.
            //Należy stworzyć repertuar, pobrać od klienta dane osobowe(wybrany film, godzinę
            //seansu, imię, nazwisko, telefon, mail oraz liczbę biletów) a następnie wyświetlić
            //podsumowanie rezerwacji.

            Console.WriteLine("Witaj w systemie rezerwacji biletów!");
            Console.WriteLine();

            //Etap 1: Tworzymy tablicę, która przechowa filmy.
            string[] filmy = { "Avatar", "John Wick 4", "Ant-Man i Osa: Kwantomania", "Asterix i Obelix" };

            //Etap 2: Tworzymy tablicę, która będzie przechowywać godziny seansów.
            string[] godziny = { "13:30", "16:40", "18:40", "20:25" };

            //Etap 3: Wyświetlamy filmy użytkownikowi i prosimy o wybór filmu i godziny seansu.
            Console.WriteLine("Oto nasz repertuar:");
            for(int i = 0; i < filmy.Length; i++)
            {
                Console.WriteLine($"{i+1} - {filmy[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Wybierz film:");
            string wybranyFilm = filmy[int.Parse(Console.ReadLine()) - 1 ];

            Console.WriteLine();
            Console.WriteLine($"Wybrany film {wybranyFilm} chodzi w godzinach:");
            for(int i = 0;i < godziny.Length; i++)
            {
                Console.WriteLine($"{i+1} - {godziny[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Wybierz godzinę:");
            string wybranaGodzina = godziny[int.Parse(Console.ReadLine()) - 1];

            //Etap 4: Pobieramy resztę informacji od użytkownika imię, nazwisko, telefon, mail oraz liczbę biletów.
            string[] info = { "imię", "nazwisko", "telefon", "mail", "liczbę biletów" };
            string[] infoOdUsera = new string[5];

            Console.WriteLine("Podaj dane do rezerwacji");
            Console.WriteLine();

            for(int i = 0; i < info.Length ; i++) 
            {
                Console.WriteLine($"Podaj {info[i]}");
                infoOdUsera[i] = Console.ReadLine();
            }


            //Etap 5: Wypisujemy potwierdzenie rezerwacji z wszystkimi danymi.

            Console.ReadLine();

        }
    }
}
