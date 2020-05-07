using System;
using GrowPlant.Model;

namespace GrowPlant{
  public class Program{
    static Plant plant = new Plant();
    public static void Grow(){
      Console.WriteLine($"{plant.Name} initial status: \nHight: {plant.Hight} inches \nWaterlevel: {plant.Waterlevel} \nHappyness: {plant.Happyness} \n");
      Console.WriteLine("How do you want to take care your plant \n Option: Water | Feed | Give Sunhine ");
      string userInput = Console.ReadLine();
      userInput.ToLower();
      if(userInput == "water"){
          plant.Water();
          
      }else if(userInput == "feed"){
        plant.Feed();
      }else if(userInput == "give sunshine"){
        plant.SunShine();
      }else{
        Console.WriteLine("Come back later to take care your plant.");
      }
      CheckStatus();
      }
    public static void CheckStatus(){
      if(plant.IsAlive){
       Console.WriteLine($"{plant.Name} current status: \nHight: {plant.Hight} inches \nWaterlevel: {plant.Waterlevel} \nHappyness: {plant.Happyness} \n");
      }
    }
    public static void Main(){
      
      Console.WriteLine("Let's grow a plant");
      Console.WriteLine("Make your plant taller and happier! \nReminder*** Onece water level hits more than 10 or less than 0 your plant will die. ");
      Console.WriteLine("Let's name your plant");
      string name = Console.ReadLine();
      plant.Name = name;
      
    Grow();
    }
  }
}