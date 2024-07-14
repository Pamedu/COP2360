using System;

public enum FurColor
{
    White,Brown,Black,Grey,Orange
}
public class Bunny
{
    public string Name;
    public bool LikesCarrots, LikesHumans;
    public FurColor Color;

    public Bunny() {}
    public Bunny(string n) => Name = n;

  public Bunny (string name,bool likesCarrots = false,bool likesHumans = false, FurColor color = FurColor.White)
  {
    Name = name;
    LikesCarrots = likesCarrots;
    LikesHumans = likesHumans; 
    Color = color;
  }


    public static void Main(string[] args)
    {
        Bunny b1 = new Bunny { Name="Ed", LikesCarrots=true, LikesHumans=true, Color=FurColor.Grey};
        Bunny b2 = new Bunny { Name="Bo", LikesCarrots=true, LikesHumans=false, Color=FurColor.Orange};

        Console.WriteLine($"Bunny 1: Name = {b1.Name}, Likes Carrots = {b1.LikesCarrots}, Likes Humans = {b1.LikesHumans}, Color = {b1.Color}");
        Console.WriteLine($"Bunny 2: Name = {b2.Name}, Likes Carrots = {b1.LikesCarrots}, Likes HUmans = {b2.LikesHumans}, Color = {b2.Color}");

        Console.ReadKey();
    }
}

 


