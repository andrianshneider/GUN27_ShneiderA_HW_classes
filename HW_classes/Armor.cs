using System;
namespace HW_classes
{
    public class Helm
    {
        public string name { get; }
        public float armor;

        public Helm() : this("Helm")
        {
        }

        public Helm(string argName)
        {
            name = argName;
        }

        public Helm(string argName, float argArmor)
        {
            name = argName;
            armor = argArmor;
        }

        public float Armor
        {
            get
            {
                return armor;
            }

            set
            {
                if (value>1f)
                {
                    armor = 1f;
                    Console.WriteLine($"Некорректное значение! Значение брони шлема установлено на {armor}");
                }
                else
                {
                    if (value < 0f)
                    {
                        armor = 0f;
                        Console.WriteLine($"Некорректное значение! Значение брони шлема установлено на {armor}");
                    }
                    else
                    { armor = value; }
                }
            }
        }
    }

    public class Shell
    {
        public string name { get; }
        public float armor;

        public Shell() : this("Shell")
        {
        }

        public Shell(string argName)
        {
            name = argName;
        }

        public Shell(string argName, float argArmor)
        {
            name = argName;
            armor = argArmor;
        }

        public float Armor
        {
            get
            {
                return armor;
            }

            set
            {
                if (value > 1f)
                {
                    armor = 1f;
                    Console.WriteLine($"Некорректное значение! Значение брони кирасы установлено на {armor}");
                }
                else
                {
                    if (value < 0f)
                    {
                        armor = 0f;
                        Console.WriteLine($"Некорректное значение! Значение брони кирасы установлено на {armor}");
                    }
                    else
                    { armor = value; }
                }
            }
        }
    }

    public class Boots
    {
        public string name { get; }
        public float armor;

        public Boots() : this("Boots")
        {
        }

        public Boots(string argName)
        {
            name = argName;
        }

        public Boots(string argName, float argArmor)
        {
            name = argName;
            armor = argArmor;
        }

        public float Armor
        {
            get
            {
                return armor;
            }

            set
            {
                if (value > 1f)
                {
                    armor = 1f;
                    Console.WriteLine($"Некорректное значение! Значение брони сапог установлено на {armor}");
                }
                else
                {
                    if (value < 0f)
                    {
                        armor = 0f;
                        Console.WriteLine($"Некорректное значение! Значение брони сапог установлено на {armor}");
                    }
                    else
                    { armor = value; }
                }
            }
        }
    }
}

