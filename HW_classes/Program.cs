using System;

internal class Program
{
    private static void Main(string[] args)
    {
        float startHealth;
        string name;
        float helmArmor;
        float shellArmor;
        float bootsArmor;
        float minDamage;
        float maxDamage;
        
        Console.WriteLine("Подготовка к бою:");
        Console.WriteLine("Введите имя бойца:");

        name = Console.ReadLine();

        float number; 
        bool valid; 

        do
        {
          Console.Write("Введите начальное здоровье бойца (10-100):"); 
          valid = float.TryParse(Console.ReadLine(), out number); 
          if (!valid || number < 10 || number > 100) 
            {
              Console.WriteLine("Неверный ввод. Попробуйте еще раз."); 
            }
        }
        while (!valid || number < 10 || number > 100); 

        startHealth = number;

        do
        {
            Console.Write("Введите значение брони шлема от 0. до 1:");
            valid = float.TryParse(Console.ReadLine(), out number);
            if (!valid || number < 0 || number > 1)
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
            }
        }
        while (!valid || number < 0 || number > 1);

        helmArmor = number;

        do
        {
            Console.Write("Введите значение брони кирасы от 0. до 1:");
            valid = float.TryParse(Console.ReadLine(), out number);
            if (!valid || number < 0 || number > 1)
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
            }
        }
        while (!valid || number < 0 || number > 1);

        shellArmor = number;

        do
        {
            Console.Write("Введите значение брони ботинок от 0. до 1:");
            valid = float.TryParse(Console.ReadLine(), out number);
            if (!valid || number < 0 || number > 1)
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
            }
        }
        while (!valid || number < 0 || number > 1);

        bootsArmor = number;

        do
        {
            Console.Write("Укажите минимальный урон оружия (0-20):");
            valid = float.TryParse(Console.ReadLine(), out number);
            if (!valid || number < 0 || number > 20)
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
            }
        }
        while (!valid || number < 0 || number > 20);

        minDamage = number;

        do
        {
            Console.Write("Укажите максимальный урон оружия (0-20):");
            valid = float.TryParse(Console.ReadLine(), out number);
            if (!valid || number < 0 || number > 20)
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
            }
        }
        while (!valid || number < 0 || number > 20);

        maxDamage = number;

        var Unit = new HW_classes.Unit(name, startHealth);

        Unit.EquipWeapon(minDamage, maxDamage);
        Unit.EquipHelm("Helm", helmArmor);
        Unit.EquipShell("Shell", shellArmor);
        Unit.EquipBoots("Boots", bootsArmor);

        Console.WriteLine("_________________");
        Console.WriteLine("Профиль вашего бойца:");
        Console.WriteLine($"ИМЯ: {Unit.Name}");
        Console.WriteLine($"ОБЩИЙ ПОКАЗАТЕЛЬ БРОНИ: {Unit.Armor}");
        Console.WriteLine($"ОБЩИЙ УРОН ОРУЖИЯ: {Unit.Damage}");
        Console.WriteLine($"ФАКТИЧЕСКОЕ ЗНАЧЕНИЕ ЗДОРОВЬЯ: {Unit.RealHealth}");
    }
}