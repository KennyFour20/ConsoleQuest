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
            
            
            //IntroductionAmend();
            //Console.ReadKey();
            //MainIntro();
            // NewClass();
            Console.ReadKey();


            Introduction();
           

        }



        

        static void Introduction()
        {
            Console.Write("Enter your Name:");
            string NamePlace = Console.ReadLine();
            Console.WriteLine("Greetings" + NamePlace + " Good to see you back");
            Console.ReadLine();

        }

        static void IntroductionAmend()
        {
            Console.Write("Kia ora\nWelcome to my first test program" +
                "\nI have thought of a great idea to do with a cosole based RPG.");
            Console.ReadKey();
            Console.Write("\nSo basically, it will be based on the console and what you choose is how the aventure goes.\n" +
                "You will create a custom adventure and choosing a class to fit your style.\n" +
                "When it comes to adventure you will be the guide of your own quest.\n" +
                "Realistcaly I haven't come up with much. But as a project to start from.......\n");

            Console.Write("____________________________________\n" +
                "\"Press Any Key To Continue\"");
            Console.Write("\n____________________________________\n");
            Console.ReadKey();

            Console.Write("When you start, there is going to be some character customization\"Fitting\",Right?\n" +
                "When creating your character you will be given a choise of 4 Preset \"Classes\".\n" +
                "These classes signify the foundations of your characters attributes\n" +
                "when given the choice you should choose between:\n");
            Console.Write("____________________________________\n" +
                "\"Continue to view Classes:\"");
            Console.Write("\n____________________________________\n");
            Console.ReadKey();
            Console.Write("Class list:\n");
            Console.Write("____________________________________\n");
            Console.WriteLine("\n");
            Console.WriteLine("\"Adventurer\"");
            Console.ReadKey();
            Console.WriteLine("\"Mage\"");
            Console.ReadKey();
            Console.WriteLine("\"Rouge\"");
            Console.ReadKey();
            Console.WriteLine("\"Warrior\"");
            Console.Write("\n____________________________________\n");
            Console.ReadKey();

            Console.Write("And with these classes you will begin your quest." +
                "\nThe game you will play will varry slightley with the choices you make, attempting to create a unique\n" +
                "gamming experiance. When this idea came to me, I felt like it could be used as a key to unlock,\n" +
                "and create the potential of becoming a programer. Thank you to all who have assisted me\n" +
                "and all who have given me the foundational knowledge to progress in this feild.\n\n\n");
            Console.WriteLine("Enjoy the gameplay :) <3 ...");
            Console.ReadKey();
        }

        static void MainIntro()
        {
            Console.Clear();
            Console.Write("There is a cold wind.\nAs the breeze blows you find yourself to be entranced.\n" +
                "You can feel the blood dripping off the soles of your feet, onto the floor...");
            Console.ReadKey();
            Console.Write("Drip...");
            Console.ReadKey();
            Console.Write("Drip...");
            Console.ReadKey();
            Console.Write("Drip...\n");
            Console.ReadKey();
            Console.Write("\nYou look up to see why you can't move your hands..\n" +
                "They're bound by shackles, Chains of pure iron, cuffs of cold steel.\n" +
                "You look to the far side of the room and see another person, he looks back at you\n" +
                "and returns a \"smile\". ");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\"The Name's Bryan....\"");
            Console.ReadKey();
            Console.Write("\n\"In this place we are equals, no majersty, no sire...\"" +
                "\n\"Just you....\"\n");
            Console.ReadKey();
            Console.Write("\"...and me\"");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\"I bet your pretty face don't know how it ended up here eh?\"\n" +
                "\"I bet you even think you're innocent...\"\n");
            Console.ReadKey();
            Console.Write("\"Pig...\"\n");
            Console.ReadKey();
            Console.Write("\"you might be interested to find out about your future? But a pig like you wouldn't know how to take it though\"");
            Console.ReadKey();
            Console.Write("\n\n\n You look into Bryans eyes and see them glint, he might be holding somthing back...?\n\n\n");
            Console.ReadKey();
            Console.Write("\"You know what pain is, Pig?\"");

            Console.ReadLine();



            Console.ReadKey();

        }

        






    }

}  





