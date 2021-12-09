using System;

namespace Else_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Greeting();
           Loop();
           Loop2();
           Ending();

          







        }

        public static void PickYourPoisen()
        {



        }
        public static void Greeting()
        {
            Console.WriteLine("Hello lucky contestent!");
            Console.WriteLine();
            Console.WriteLine("What is  your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Well then {name}, let me explain the game. You are in a room with 4 doors, with a number labling each.");
            Console.WriteLine();
            Console.WriteLine($"There will also be a riddle or question to solve. And if you get stuck, each room will have one hint!");
            Console.WriteLine();
            Console.WriteLine($"Ready {name}? Okay here we go!");
        }
        public static bool Room1()
        {
            Console.WriteLine("You have entered the first room. There are four doors.");
            Console.WriteLine("The question is,what number would you get, if you took the number of days in the week and mulitply it by the months of the year");
            Console.WriteLine("And then divide it by the amount of points on a triangle?");
            Console.WriteLine();
            Console.WriteLine("Door 1 says 32 \n" +
                              "Door 2 says 58 \n" +
                              "Door 3 says 28 \n" +
                              "Door 4 says 27 \n");

            bool rightAnswer;

            Console.WriteLine("Type in what door number you think it is!");
            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == 1)
            {
                string message = ("The door opens onto a cliff. You barely avoid falling!");
                Console.WriteLine(message);
                rightAnswer = true;
                return rightAnswer;
            }
            else if (userAnswer == 2)
            {
                string message =(" The door is locked.. try another one.");
                Console.WriteLine (message);
                rightAnswer = true;
                return rightAnswer;
            }
            else if (userAnswer == 3)
            {
                string  message = ("Well done, you walk into the next room");
                Console.WriteLine(message);
                rightAnswer = false;
                return rightAnswer;
            }
            else if (userAnswer == 4)
            {
                string messege = ("You narrowly dodge an arrow shot from the open door. Better try another door");
                Console.WriteLine(messege);
                rightAnswer = true;
                return rightAnswer;
            }
            else
            {
                Console.WriteLine("There are 7 days in a week and 12 months in the year! Just do the math");
                rightAnswer = false;
                return false;
            }
             
            


        }



        public static void Loop()
        {
            bool Conditional = true;

            while (Conditional)
            {
               var rightDoor = Room1();
               Conditional = rightDoor;
               
            }

        }
    

        public static bool Room2()
        {
            Console.WriteLine("You have entered the second room. There are four doors.");
            Console.WriteLine("The question is, who was the 35th President of the United States?");
            Console.WriteLine();
            Console.WriteLine("Door 1 says Dwight D. Eisenhower \n" +
                              "Door 2 says John F. Kennedy\n" +
                              "Door 3 says Gerald R. Ford \n" +
                              "Door 4 says Herbert Hoover \n");
            var answer = Console.ReadLine();
            bool asw;
            switch (answer)
            {
                case "1":
                    Console.WriteLine("Door is locked, try again");
                    asw = true;
                    return asw;
                        break;
                case "2":
                    Console.WriteLine("Congrats, you know history");
                    asw = false;
                    return asw;
                    break;
                case "3":
                    Console.WriteLine("The door opens onto an empty stretch of wall...try again");
                    asw = true;
                    return asw;
                    break;
                case "4":
                    Console.WriteLine("You see a normal hallway with a sign saying 'free audits' ... you close the door and try again.");
                    asw = true;
                    return asw;
                    break;
                default: Console.WriteLine("Here's a hint.. he died...");
                    asw = true;
                    return asw;
                    break;
            }




        }




        public static void Ending()
        {

            Console.WriteLine("well done! you've solved all th quesions!");
        }

        public static void Loop2()
        {
            bool Conditional = true;

            while (Conditional)
            {
                var rightDoor = Room2();
                Conditional = rightDoor;

            }

        }
    }

}
