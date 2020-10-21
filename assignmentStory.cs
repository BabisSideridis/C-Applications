using System;

namespace assignmentStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your name");
            string name = Console.ReadLine();
            Console.WriteLine("Give your age");
            int age = int.Parse(Console.ReadLine());

            while (age < 0)//ελεγχος
            {
                Console.WriteLine("The age should be positive");
                Console.WriteLine("Give your age");
                age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Give your weight");
            int weight = int.Parse(Console.ReadLine());

            while (weight < 0)//ελεγχος
            {
                Console.WriteLine("The weight should be positive");
                Console.WriteLine("Give your weight");
                age = int.Parse(Console.ReadLine());
            }

            string[] colors = { "White", "Pink", "Red", "Green", "Blue", "Black" }; //δημιουργια λιστας
            string[] shirtSizes = { "Small", "Medium", "Large", "X-Large" };        //δημιουργια λιστας

            string userColor = ""; //variable for colors
            string usershirtSize = "";//variable for size


            if (age >= 0 && age <= 17)//if for age
            {
                userColor = colors[0];
            }
            else if (age > 17 && age <= 24)
            {
                userColor = colors[1];
            }
            else if (age > 24 && age <= 35)
            {
                userColor = colors[2];
            }
            else if (age < 35 && age <= 45)
            {
                userColor = colors[3];
            }
            else if (age < 45 && age <= 55)
            {
                userColor = colors[4];
            }
            else
            {
                userColor = colors[5];
            }


            if (weight <= 50)//if for wieght
            {
                usershirtSize = shirtSizes[0];
            }
            else if (weight > 50 && weight <= 64)
            {
                usershirtSize = shirtSizes[1];
            }
            else if (weight >= 65 && weight <= 79)
            {
                usershirtSize = shirtSizes[2];
            }
            else
            {
                usershirtSize = shirtSizes[3];
            }

            Console.WriteLine("Hey " + name + ", it is cool to be " + age + " years old!  You should buy a " + userColor + " " + usershirtSize + " shirt");
        }
    }
}
