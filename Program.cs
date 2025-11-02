using System;
using System.Collections.Generic;

class FlowerFactory
{
    private Dictionary<string, string> flowers = new Dictionary<string, string>();

    public string GetFlower(string type)
    {
        if (!flowers.ContainsKey(type))
        {
            flowers[type] = $"Створено новий об’єкт: {type}";
        }
        return flowers[type];
    }
}

class Program
{
    static void Main()
    {
        var factory = new FlowerFactory();

        Console.WriteLine(factory.GetFlower("Троянда"));
        Console.WriteLine(factory.GetFlower("Троянда")); // Використовує існуючий
    }
}








