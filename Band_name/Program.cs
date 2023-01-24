//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//methods require a name and parameters.
//Name-The name well use to call the method throughout our program
//Parameters-values passed into the method.

//PascalCase naming convention for Method
//camelCase naming convention used for parameters
using System;

class Program //Class program
{
    static void Main(string[] args) //Method main, methodsallow us to break our code into reusable functional blocks
    {
        Console.WriteLine("What is th name of your band?");
        Band band = new Band();
        band.Name = Console.ReadLine();

        Console.WriteLine("Type 'Add' to add a musiciain.");
        Console.WriteLine("Type 'Announce' to announce the band.");
        Console.WriteLine("Type 'Quit' to quit the application.");

        var repeat = true;
        while(repeat)
        {
            Console.WriteLine("Add, Announce, or Quit?");
            var action = Console.ReadLine();
            if(action == "Add")
            {
                band.AddMusician();
            }
            else if(action.StartsWith("Add"))
            {
                var arguments = action.Split(' ');
                if(arguments.Length == 3)
                {
                    band.AddMusician(arguments[1], arguments[2]);
                }
                else
                {
                    band.AddMusician();
                }
            }
            else if(action == "Announce")
            {
                band.Announce();
            }
            else if(action == "Quit")
            {
                repeat = false;
            }
            else
            {
                Console.WriteLine(action + " is not a valid command");
            }
        }

        Console.WriteLine("Thank you!");
    }
    //static void AnnounceBand(string bandName)
    //{
    //    Console.WriteLine("Welcome " + bandName + " to the stage!");
    //}
}

