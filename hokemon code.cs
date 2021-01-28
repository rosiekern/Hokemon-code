using System;
using System.Collections.Generic;

namespace Hokemon_T
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon!");

            // Instantiation of new Hokemon

            Hokemon hoke01 = new Hokemon();  // INSTANTIATE new Hokemon object referred to as Hoke01

            hoke01.get_details();
            Console.WriteLine("Attack value is: {0}", hoke01.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hoke01.defenceCalculator());

            Hokemon hoke02 = new Hokemon();  // INSTANTIATE Hoke02

            hoke02.get_details();
            Console.WriteLine("Attack value is: {0}", hoke02.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hoke02.defenceCalculator());

            Hokemon hokemonObject = new Hokemon();  // INSTANTIATE hokemonObject

            hokemonObject.get_details();
            Console.WriteLine("Attack value is: {0}", hokemonObject.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hokemonObject.defenceCalculator());

            Hokemon hoke03 = new Hokemon();  // INSTANTIATE from Hokemon Parent class

            //Halor hoke04 = new Halor(); // INSTANTIATE from Halor child class
            //Console.WriteLine("I am part of {0} team.", hoke04.team);

            // Demonstrating an example of POLYMORPHISM
            //         with hoke03 an INSTANCE of Hokemon class
            //         with hoke04 an INSTANCE if Halor class inherited from Hokemon class
            //hoke03.definition();
            //hoke04.definition();


            Console.WriteLine("\nDo you want to battle?Y/N");
            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("\n[1] {0}\n[2] {1}\n[3] {2}\n[4] {3}\nPick your first hokemon", hoke01.Name, hoke02.Name, hokemonObject.Name, hoke03.Name);

                var list = new List<Hokemon>() { hoke01, hoke02, hokemonObject, hoke03 };
                Hokemon attackerHoke = list[Convert.ToInt32(Console.ReadLine()) - 1];
                Console.WriteLine("Pick your second hokemon");
                Hokemon defenderHoke = list[Convert.ToInt32(Console.ReadLine()) - 1];
                Battle_Arena newBattleObject = new Battle_Arena();

                newBattleObject.requestAChallenger(attackerHoke);  // In newBattleObject passing 
                                                             // Hoke02 object as an 
                                                             // Argument
                newBattleObject.theBattle(attackerHoke, defenderHoke);
            }
               


            

        }
    }
}