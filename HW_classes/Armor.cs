using System;
namespace HW_classes
{
    public class Helm
    {
        public readonly string Name;
        public float Armor;

        public Helm() : this("Helm")
        {
        }

        public Helm(string ArgName)
        {
            Name = ArgName;
        }

        public float ArmorProperty
        {
            get
            {
                return Armor;
            }

            set
            {
                if (value>1f)
                {
                    Armor = 1f;
                    Console.WriteLine($"Некорректное значение! Значение брони шлема установлено на {Armor}");
                }
                else
                {
                    if (value < 0f)
                    {
                        Armor = 0f;
                        Console.WriteLine($"Некорректное значение! Значение брони шлема установлено на {Armor}");
                    }
                    else
                    { Armor = value; }
                }
            }
        }
    }

    public class Shell
    {
        public readonly string Name;
        public float Armor;

        public Shell() : this("Shell")
        {
        }

        public Shell(string ArgName)
        {
            Name = ArgName;
        }

        public float ArmorProperty
        {
            get
            {
                return Armor;
            }

            set
            {
                if (value > 1f)
                {
                    Armor = 1f;
                    Console.WriteLine($"Некорректное значение! Значение брони кирасы установлено на {Armor}");
                }
                else
                {
                    if (value < 0f)
                    {
                        Armor = 0f;
                        Console.WriteLine($"Некорректное значение! Значение брони кирасы установлено на {Armor}");
                    }
                    else
                    { Armor = value; }
                }
            }
        }
    }

    public class Boots
    {
        public readonly string Name;
        public float Armor;

        public Boots() : this("Boots")
        {
        }

        public Boots(string ArgName)
        {
            Name = ArgName;
        }

        public float ArmorProperty
        {
            get
            {
                return Armor;
            }

            set
            {
                if (value > 1f)
                {
                    Armor = 1f;
                    Console.WriteLine($"Некорректное значение! Значение брони сапог установлено на {Armor}");
                }
                else
                {
                    if (value < 0f)
                    {
                        Armor = 0f;
                        Console.WriteLine($"Некорректное значение! Значение брони сапог установлено на {Armor}");
                    }
                    else
                    { Armor = value; }
                }
            }
        }
    }
}

