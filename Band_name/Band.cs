using System; //Allows you to reference a namespace throughout a file with a using directive
using System.Collections.Generic; //This is where Lists lives
//Arrays are best used for a group of strongly-typed objects of a fixed number.
//Lists are great for handling a group of strongly-typed objects of unknown or varying number.

public class Band
{//Objects
    public string Name;
    public List<Musician> Musicians = new List<Musician>();

    public void AddMusician()
    {
        Console.WriteLine("What is the name of the musician to be added?");
        var name = Console.ReadLine();
        Console.WriteLine("What instrument does " + name + " play?");
        var instrument = Console.ReadLine();
        AddMusician(name, instrument);
    }

    //Havimg two methods in the same class with same name is allowed if they have different signatures
    // Resuing a method Name with a different Method Signature is called a method overload.
    //Method Sigs consist of the Mthod name and Parameter types.
    public void AddMusician(string name, string instrument)
    {
        var musician = new Musician();
        musician.Name = name;
        musician.Instrument = instrument;
        Musicians.Add(musician);
    }

    public void Announce() //Method
    {
        Console.WriteLine("welcome " + Name + " to the crazy stage!");

        foreach(var musician in Musicians)
        {
            musician.Announce();
        }
    }
}