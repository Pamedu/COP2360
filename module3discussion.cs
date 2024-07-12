using System;


public enum FurColor
{
    white,brown,black,Grey,Orange
}
public class Bunnyexample
{
    public string Name;
    public bool LikesCarrots, LikesHUmans;
    public FurColor color;

    public Bunnyexample(){}
    public Bunnyexample(string n) => Name = n;

  public Bunnyexample (string name,bool likesCarrots = false,bool likesHumans = false)
  {
    Name = name;
    LikesCarrots = likesCarrots;
    LikesHumans = likesHumans; 
  }

    public static void Main(string[] args)
    {
        Bunnyexample b1 = new Bunnyexample { Name="Ed", LikesCarrots=true, LikesHumans=true };

        Console.WriteLine($"Bunny 1: Name = {b1.Name}, Likes Carrots = {b1.LikesCarrots}, Likes Humans = {b1.LikesHumans}");

        Console.ReadKey();
    }
}

 


