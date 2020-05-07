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
    if(Waterlevel < 7){
      Hight += 1;
      Waterlevel +=2;
      Happyness += 1;
    }else{
      Waterlevel +=2;
      Happyness -= 2;
    }
    
  }
  public void Feed(){
    Hight += 1;
    Happyness += 2;
  }

  public void SunShine(){
    if(Waterlevel >4){
    Hight += 1;
    Waterlevel -= 1;
    Happyness += 1;
    }else{
      Happyness -= 2;
       Waterlevel -= 1;
    }
  }

  public void Reset(){
    Name = "";
    Hight = 0;
    Waterlevel = 3;
    Happyness = 2;
    IsAlive = true;
  }
  
 }
  
}