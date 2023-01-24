using System;

public class Musician
{
	public string Name;
	public string Instrument;

	public void Announce()
	{
		Console.WriteLine("Welcome " + Name + " they play " + Instrument);
	}
}

