using System;

class Program {
    static void Main() {
        Console.Write("Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сума: {num1 + num2}");
    }
}
