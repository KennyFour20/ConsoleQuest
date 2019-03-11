using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionAmend();
            Introduction();
            
        }


        static void Introduction()
        {
            Console.WriteLine("Greetings");
            Console.ReadKey();
            Console.WriteLine("How are you?");
            Console.ReadKey();
            Console.WriteLine("Traveld much lately?");
            Console.ReadKey();
            Console.WriteLine("Well we have a treet for you....");
            Console.ReadKey();
            Console.WriteLine("Many times people came");
            Console.ReadKey();
            Console.WriteLine("And Many times they failed miseralby");
            Console.ReadKey();
            Console.WriteLine("Easment was what they craved");
            Console.ReadKey();
            Console.WriteLine("and when they got what they searched for");
            Console.ReadKey();
            Console.WriteLine("Life became a sore monstrosity");
            Console.ReadKey();
            Console.Write("---------------------------------\n" +
                "Before the weather changed for good, the sun used to sine down like a holy bight,\n" +
                "When the rain falls down from the south and makes the ground moist\n" +
                "we slip and struggle to find our way for days.....\n" +
                "There is something going to happen, one day...............\n" +
                "I can feel it......");
            Console.ReadKey();
        }

        static void IntroductionAmend()
        {
            Console.Write("Kia ora\nWelcome to my first test program" +
                "\nI have thought of a great idea to do with a cosole based RPG.");
            Console.ReadKey();
            Console.Write("\nSo basicaly, it will be based on console and what you choose is how it goes\n" +
                "you will create a custom adventure and choosing a class to fit your style.\n" +
                "When it comes to adventure you will be the guide of your own quest.\n" +
                "Realistcaly I haven't come up with much. But as a project to start from.......\n");

            Console.Write("------------------------------------\n" +
                "\"Press Any Key To Continue\"");
            Console.Write("\n------------------------------------\n");
            Console.ReadKey();

            Console.Write("When you start, there is going to be some character customization\"Fitting\",Right?\n" +
                "When creating your character you will be given a choise of 4 Preset \"Classes\".\n" +
                "These classes signify the foundations of your characters attributes\n" +
                "when given the choice you should choose between:\n");
            Console.Write("------------------------------------\n" +
                "\"Continue to view Classes:\"");
            Console.Write("\n____________________________________\n");
            Console.ReadKey();
            Console.Write("Classes list:\n");
            Console.Write("____________________________________\n");
            Console.WriteLine("\"Adventurer\""); 
            Console.WriteLine("\"Mage\"");
            Console.WriteLine("\"Rouge\"");
            Console.WriteLine("\"Warrior\"");


    }

}

        }   





