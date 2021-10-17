using System;
using System.Collections.Generic;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentData = new List<Student>();
            studentData.Add(new Student("Andy Beer", "Berkley, MI", "French Fires"));
            studentData.Add(new Student("Cassly Sullen", "Detroit, MI", "Steak"));
            studentData.Add(new Student("Phillip Conrad", "Canton, MI", "Fried Chicken"));
            studentData.Add(new Student("Zachary Parr", "Wyandotte, MI", "Sushi"));
            studentData.Add(new Student("Cortez Christian", "Detroit, MI", "Chicken Fettuccine Alfredo"));
            studentData.Add(new Student("Erin Walter", "Troy, MI", "Tacos"));
            studentData.Add(new Student("James Mitchell", "Yap, FSM", "Katsu"));
            studentData.Add(new Student("Cullin Flynn", "Fowlerville, MI", "Pad Thai"));
            studentData.Add(new Student("Cordero Ebberhart", "Berkley, MI", "BBQ"));
            studentData.Add(new Student("Rick Magdaleno", "Gilbert, AZ", "Hamburger"));

            Console.WriteLine(studentData.Count);

            /*string[] hometown = new string[10];
            hometown[0] = "Hometown is: Berkley, MI";
            hometown[1] = "Hometown is: Detroit, MI";
            hometown[2] = "Hometown is: Canton, MI";
            hometown[3] = "Hometown is: Wyandotte, MI";
            hometown[4] = "Hometown is: Detroit, MI";
            hometown[5] = "Hometown is: Troy, MI";
            hometown[6] = "Hometown is: Yap, FSM";
            hometown[7] = "Hometown is: Fowlerville, MI";
            hometown[8] = "Hometown is: Berkley, MI";
            hometown[9] = "Hometown is: Gilbert, AZ";

            string[] favfood = new string[10];
            favfood[0] = "Favorite food is: French Fries";
            favfood[1] = "Favorite food is: Steak";
            favfood[2] = "Favorite food is: Fried Chicken";
            favfood[3] = "Favorite food is: Sushi";
            favfood[4] = "Favorite food is: Chicken Fettuccine Alfredo";
            favfood[5] = "Favorite food is: Tacos";
            favfood[6] = "Favorite food is: Katsu";
            favfood[7] = "Favorite food is: Pad Thai";
            favfood[8] = "Favorite food is: BBQ";
            favfood[9] = "Favorite food is: Hamburger";
            */
            bool goOn = true;
            while (goOn == true)
            {
                bool validNum = false;
                int validName = 0;
                while (validNum == false)
                {
                    Console.WriteLine("Welcome to our class!");
                    string answer = UserInput("Which student would you like to know more about? Please enter an integer between 1-10.");
                    int name = int.Parse(answer);
                    if (name >= 1 && name <= 10)
                    {
                        validNum = true;
                        validName = name;
                    }
                    else
                    {
                        Console.WriteLine("That input was not correct, please enter an integer between 1-10.");
                    }
                    for (int i = 0; i < studentData.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {studentData[i].Names}");
                        Console.WriteLine($"{i + 1}: {studentData[i].HomeTown}");
                        Console.WriteLine($"{i + 1}: {studentData[i].FavoriteFood}");
                    }
                }



                //string reply = UserInput("Now that you have chosen your student, please choose to learn about either Hometown or FavoriteFood!");
                //if (reply == "Hometown")
                //{
                //    Console.WriteLine((studentData[0].HomeTown[validName - 1]));
                //}
                //else if (reply == "FavoriteFood")
                //{
                //    Console.WriteLine(studentData[0].FavoriteFood[validName - 1]);
                //}
                //else
                //{
                //    Console.WriteLine("That was not an acceptable answer! Please try again!");
                //    Continue();
                //}

                goOn = Continue();
            }

        }
        public static string UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;

        }
        public static bool Continue()
        {
            string response = UserInput("Would you like to know more about another student? y/n");

            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                Console.WriteLine("Good bye!");
                return false;

            }
            else
            {
                Console.WriteLine("That was not a valid response, please try again!");
                return Continue();
            }
        }
    }
}