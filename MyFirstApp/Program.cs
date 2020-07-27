using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var monster = new Monster();

            // monster.health = 2;

            Console.WriteLine(monster.health);
            monster.receiveDamage();
            Console.WriteLine(monster.health);

            #region Monster example
            //var monster = new Monster();
            //Console.WriteLine(monster.health);
            //monster.receiveDamage();
            //Console.WriteLine(monster.health);
            //Console.WriteLine(monster.attack);
            #endregion

            // var warrior = new Warrior();

            // Console.WriteLine(warrior.Speak("some text"));          

            // var MyCharacter = new Warrior(); // --->>

            // Console.WriteLine(MyCharacter.Name);
            // Console.WriteLine(MyCharacter.Age);
            // Console.WriteLine("");
            // Console.WriteLine(MyCharacter.Speak("test"));

            // int number = 0;
            // string text = "asdf";
            // MyCharacter.displayOnConsole(text);
            // //MyCharacter.displayOnConsole(number);

            // MyCharacter.Age = 2323;

            #region Variables Examples
            //Variables 
            //string Mystring = "Tor";  // Text
            //bool MyBool = true; // True / false (1/0)
            //DateTime myDate = DateTime.Now; // datetime
            //int myInt = 20; // number (hard numbers)
            //float myFloat = 4f; // number with better presition (number with comma)

            //var MyVar = "tor"; // Var .. Wildcard declaration
            #endregion
            #region IF Statement
            // IF Statement
            //var myCheck = 1;

            //// || = Or
            //// && = And 

            //if (myCheck == 1 || myCheck == 2) // need double = (==) to check if ifcheck contains 1
            //{
            //    Console.WriteLine("its 1 or 2");
            //}
            //else
            //{
            //    Console.WriteLine("its not 1 or 2");
            //}
            #endregion
            #region SWITCH Statemement
            //var mySwitchVar = 4;

            //switch (mySwitchVar)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("its one or two");
            //        break;

            //    case 3:
            //        Console.WriteLine("its three");
            //        break;

            //    case 4:
            //        Console.WriteLine("its four");
            //        break;

            //    default:
            //        Console.WriteLine("this is a default value");
            //        break;
            //}

            //if (mySwitchVar == 1 || mySwitchVar == 2) {

            //}
            //else if (mySwitchVar == 3) {

            //}
            //else {

            //}

            #endregion
            #region FOR Loop
            //List<string> MMRList = new List<string>();
            //MMRList.Add("nils");
            //MMRList.Add("ola");
            //MMRList.Add("gunnar");
            //MMRList.Add("J�rgen");
            //MMRList.Add("Fabian");
            //MMRList.Add("Gregor");
            //MMRList.Add("Tor");
            //MMRList.Add("Christofer");

            //for (var MyForVar = 0; MyForVar < 5; MyForVar++)
            //{
            //    Console.WriteLine(MyForVar);
            //    Console.WriteLine(MMRList[MyForVar]);
            //}

            //foreach (var item in MMRList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region WHILE Loop

            //var mycheck = true;
            //int myInt = 0;

            //while (mycheck)
            //{
            //    myInt++;
            //    Console.WriteLine(myInt);

            //    if (myInt == 5)
            //    {
            //        mycheck = false;
            //    }
            //}

            #endregion

            Console.ReadKey();
        }
    }
}
