namespace classes_structs_oop
{
    public class Character
    {
        public string name;
        public int exp;

        public Character()
        {
            name = "Not Assigned";
        }
        public Character(String name)
        {
            this.name = name;
        }
        public void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }
    }
    public struct Weapon
    {
        public string name;
        public int damage;
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            {
                huntingBow.PrintWeaponStats();
            }
        }
    }
}
