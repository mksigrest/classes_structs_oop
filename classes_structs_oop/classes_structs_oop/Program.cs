﻿namespace classes_structs_oop
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
            Reset();
        }
        public void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }
        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }
    }
    public class Paladin: Character
    {
        public Paladin(String name): Character(name)
        {

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
            huntingBow.PrintWeaponStats();

            Character villian = hero;

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "Sir Kane the Brave";

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            Weapon warBow = huntingBow;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            hero.Reset();
        }
    }
}
