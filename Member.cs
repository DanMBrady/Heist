using System;

namespace heist
{
   public class Member{

    public string Name {get;set;}

    public int Skill {get; set;}

    public double Courage {get;set;}

   public Member(string name, int skill, double courage){
    Name =name;
    Skill =skill;
    Courage =courage;
   }
   }

}