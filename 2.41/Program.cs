using System;
public class Mainclass
{
    public static void Main()
    {
        int rad, hour, min;
        Console.WriteLine("Введите значения угла");
        rad = int.Parse(Console.ReadLine());
        if (rad >= 0 && rad < 360)
        {
            min = (rad % 30) * 2;
            hour = (rad - (rad % 30)) / 30;
            Console.WriteLine($"Количество полных часов равно {hour}, минут - {min}");
        }
        else
        {
            Console.WriteLine("Введенное значение неверно");
        }
    }
}