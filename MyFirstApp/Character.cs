using System;

namespace MyFirstApp
{
    #region Character and Warrior
    public class Character
    {
        public string Name { get; set; } = "Tor";
        public int Age { get; set; } = 45;

        virtual public string Speak(string text)
        {
            return text;
        }

        public void displayOnConsole(string text)
        {
            Console.WriteLine(text);
        }
        // public void displayOnConsole(int number)
        // {
        //     Console.WriteLine(number);
        // }

    }


    public class Warrior : Character
    {
        public int Rage { get; set; }

        public override string Speak(string text)
        {
            Console.WriteLine("here i am");
            return "roar!";
        }


    }
    #endregion

    #region Monster example
    public class Monster
    {
        public int health {get; private set;} = 40;
        public int attack {get;} = 10;
        public string Name { get; set; }

        public void receiveDamage()
        {
            Console.WriteLine("inside attack");
            health = health - 5;
        }        
    }
    #endregion


}
