using System;

// клас паралелограм
class Parallelepiped
{
    //сторона паралелограма
    public double side;
    //висота паралелограма
    public double height;
 
    // метод - Площа паралелограма
    public double Square()
    {
        // перемноження атрібутів між собою, щоб дістатися до атрібуту використовуємо this + крапка
        // викорисвуємо такий підхід, а не щось типу hero.Square() тому ща це опис класу, а не обʼєкт, 
        // тому замість herо. в описі буде this. - це 
        return this.side * this.height;
    }
}

// основна програма
public class Program
{
    static void Main()
    {
        // ініціалізаія обʼєкту, який має клас паралелограм
        Parallelepiped myParallelepiped = new Parallelepiped();
        // завдання його атрибутів
        myParallelepiped.side = 3.5;
        myParallelepiped.height = 1.88;
        // вивод на екран результату роботи методу площа
        Console.WriteLine($"The square of parallelepiped is {myParallelepiped.Square()}!");
    }
}