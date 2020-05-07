using System;


namespace GrowPlant.Model{
  public class Plant{
    public string Name{get;set;}
    public int Hight{get;set;}
    public int Waterlevel{get;set;}
    public int Happyness{get;set;}
    public bool IsAlive{get;set;}

    public Plant(){
    Name = "";
    Hight = 0;
    Waterlevel = 3;
    Happyness = 2;
    IsAlive = true;
  }

  public void Water(){
    Hight += 2;
    Waterlevel +=2;
  }
  public void Feed(){
    Hight += 1;
    Happyness += 2;
  }

  public void SunShine(){
    Hight += 1;
    Waterlevel -= 1;
    Happyness += 2;
  }

  }
  
}