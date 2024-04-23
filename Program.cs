using System;

public interface IPlayable
{
    void Play();
}

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Guitar is now Playing");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Piano is now playing");
    }
    public static void Main(string[] args)
    {
        // Create instances of Guitar and Piano
        IPlayable guitar = new Guitar();
        IPlayable piano = new Piano();

        guitar.Play();
        piano.Play();
    }
}