using System;
using GrowPlant.Model;

namespace GrowPlant{
  public class Program{
    static Plant plant = new Plant();
    public static void Grow(){
      if(plant.IsAlive){
        Console.WriteLine($"{plant.Name} initial status: \nHight: {plant.Hight} inches \nWaterlevel: {plant.Waterlevel} \nHappyness: {plant.Happyness} \n");
        Console.WriteLine($"How do you want to take care {plant.Name} more \n Option: 1 (for water) | 2 (for feed) | 3 (for sunshine) ");
        string userInput = Console.ReadLine();
        userInput.ToLower();
      
        if(userInput == "1"){
          if(plant.Waterlevel < 9){
           plant.Water();
          }else{
            plant.IsAlive = false;
          }
        }else if(userInput == "2"){
          plant.Feed();
        }else if(userInput == "3"){
          if(plant.Waterlevel >1){
            plant.SunShine();
            
          }else{
            plant.IsAlive = false;
          }
          
        }else{
          Console.WriteLine(plant.Name + " is dying");
          Console.WriteLine($" Would you like to take care {plant.Name}? [y for yes n for no]");
          string answer = Console.ReadLine();
          answer.ToLower();
          if(answer == "y"){
            Grow();
          }else{
            plant.IsAlive = false;
          }
        }
      
      }
      CheckStatus();
    }
    public static void CheckStatus(){
      if(plant.IsAlive){
       Console.WriteLine($"{plant.Name} current status: \nHight: {plant.Hight} inches \nWaterlevel: {plant.Waterlevel} \nHappyness: {plant.Happyness} \n");
      }else{
        //plant.IsAlive = false;
        Console.WriteLine($"{plant.Name} died \n Game Over.");
        Main();
      }
      if(plant.IsAlive){
        Grow();
      }
      
    }
    public static void Main(){
      Console.WriteLine("Would You like to grow a plant [y for yes n for no]");
      plant.Reset();
      string respon = Console.ReadLine();
      respon.ToLower();
      if(respon == "y"){
        Console.WriteLine("Let's grow a plant");
        Console.WriteLine("Make your plant taller and happier! \nReminder*** Onece water level hits more than 10 or less than 0 your plant will die. ");
        Console.WriteLine("Let's name your plant");
        string name = Console.ReadLine();
        
        plant.Name = name.ToUpper();
        Console.WriteLine("name "+ plant.Name);
        Grow();
        
      }else{
        Console.WriteLine("Good Bye");
      }
      
    }
  }
}