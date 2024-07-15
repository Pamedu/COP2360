//In my code I used the Class Bunny and the Panda Mate/Marry method shown in Discussion 3
//I also included a Enums to label the color of my bunnies fur
//My code displays the use of fields,contructors,overloading constructors,methods,object initalizers, and more
using System;

public enum FurColor
{
    White,Brown,Black,Grey,Orange
}


public class Bunny
{   //Here you can see the use of fields
    public string Name;
    public bool LikesCarrots, LikesHumans;
    public FurColor Color;
    public Bunny Mate; // Used to store mate info
    //-------------------------------------------
    //The use of constructors as well as constructor overloading and parameters 
    public Bunny() {}
    public Bunny(string n) => Name = n;

  public Bunny (string name,bool likesCarrots = false,bool likesHumans = false, FurColor color = FurColor.White)
  {
    Name = name;
    LikesCarrots = likesCarrots;
    LikesHumans = likesHumans; 
    Color = color;
  } //Constructors
    //-------------------------------------------
  public void Marry (Bunny partner) //Method to Marry the two bunnies
  {
    Mate = partner;
    partner.Mate = this;
  }
}   //-------------------------------------------

 public class Program
{   
    public static void Main(string[] args) //Main method used to create bunnies,marry them, and display info
    {
        Bunny b1 = new Bunny { Name="Ed", LikesCarrots=true, LikesHumans=true, Color=FurColor.Grey};  //Object Initializers
        Bunny b2 = new Bunny { Name="Edna", LikesCarrots=true, LikesHumans=false, Color=FurColor.Orange};  //Object Initializers

        b1.Marry(b2); //Marrying the bunnies

        Console.WriteLine($"Bunny 1: Name = {b1.Name}, Likes Carrots = {b1.LikesCarrots}, Likes Humans = {b1.LikesHumans}, Color = {b1.Color}, Mate = {b1.Mate?.Name}");
        Console.WriteLine($"Bunny 2: Name = {b2.Name}, Likes Carrots = {b1.LikesCarrots}, Likes HUmans = {b2.LikesHumans}, Color = {b2.Color}, Mate = {b2.Mate?.Name}");

        Console.ReadKey();
    }
}


 


