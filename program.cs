using System;
using GrowPlant.Model;

namespace GrowPlant{
  public class Program{
    public static void Grow(){
      Console.WriteLine("How do you want to take care your plant \n Option: Water | Feed | Give Sunhine ");
     string userInput = Console.ReadLine();
     if(userInput == "Water"){

     }else if(userInput == "Feed"){

     }else if(userInput == " give Sunshine"){

     }else{
       
     }
    }
    public static void Main(){
      Plant plant = new Plant();
      Console.WriteLine("Let's grow a plant");
      Console.WriteLine("Make your plant taller and happier! \nReminder*** Onece water level hits more than 10 or less than 0 your plant will die. ");
      Console.WriteLine("Let's name your plant");
      string name = Console.ReadLine();
      plant.Name = name;
      Console.WriteLine("Plant name " + plant.Name);
      Grow();
    }
  }
}