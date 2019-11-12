using System;
using ClassLibrary;

namespace oop_lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People("Тарас", "Сусак", "08 квiтня 2001 року");
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Abiturient a1 = new Abiturient(100, 50, "Школа №6", p1);
            p1 = a1;
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Student s1 = new Student(4, "P-41", "Iнженерiя програмного забезпечення", "КПК НУ ЛП", a1);
            p1 = s1;
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();

            People p2 = new People("Iван", "Гоянюк", "01 сiчня 19070 року");
            p2.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Vykladach v1 = new Vykladach("Вчитель", "Конструювання ПЗ", "КПК НУ ЛП", p2);
            p2 = v1;
            p2.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();

            KorystuvachBiblioteku k1 = new KorystuvachBiblioteku(4, "4 листопада 2019", 12, s1);
            p1 = k1;
            p1.ShowInfo();
        }
    }
}
