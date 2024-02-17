internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Подготовка к бою:");
        Console.WriteLine("Введите имя бойца:");
        var Unit = new HW_classes.Unit(Console.ReadLine());
        Console.WriteLine("Введите начальное здоровье бойца (10-100):");

        var Damage = new HW_classes.Weapon("WeaponName", 100, 20);
        Console.WriteLine("_________________");
        Console.WriteLine("Профиль вашего бойца:");
        Console.WriteLine($"ИМЯ: {Unit.Name}");
        Console.WriteLine($"БРОНЯ: {Unit.Armor}");
        Console.WriteLine($"ЗДОРОВЬЕ: ???");
        Console.WriteLine($"УРОН: ???");
    }
}