using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Member> allMembers = new List<Member>(){};
            int bankSkill = 100;
            
            int teamSkill =0;
            bool saidYes =true;
            do{

            Console.WriteLine("Plan your Heist");
            Console.WriteLine("Enter Team Members Name");
            string nameOne = Console.ReadLine();
            Console.WriteLine($"Enter {nameOne}'s skill level(1-100)");
            string skillOne = Console.ReadLine();
            Console.WriteLine($"Enter {nameOne}'s Courage level(0.0-2.0)");
            string courageOne =Console.ReadLine();

            Member memberOne = new Member(nameOne, int.Parse(skillOne), double.Parse(courageOne) );

            Console.WriteLine($" Team Member {memberOne.Name} has a skill level of {memberOne.Skill} and a courage level of {memberOne.Courage}");
            allMembers.Add(memberOne);
            Console.WriteLine();
            Console.WriteLine("Add another Team Member? yes or no");
            string answer = Console.ReadLine();
            if(answer == "yes"){
                saidYes =true;
            }
            else{
                saidYes=false;
            }
            }
            while(saidYes);
           

            Console.WriteLine();
          /*  Console.WriteLine("Our Team");
            Console.WriteLine($"Number of Members:{allMembers.Count}"); */
            foreach(Member member in allMembers){
               // Console.WriteLine($"Name: {member.Name} Skill: {member.Skill} Courage: {member.Courage}");
               teamSkill = teamSkill += member.Skill;
            } 
            int successfulRuns = 0;
            int badRuns =0;
            Console.WriteLine("Enter the Banks skill level");
            int bankSelected = int.Parse(Console.ReadLine());
            Console.WriteLine("How many trial runs should be tested?");
            int trailRuns = int.Parse(Console.ReadLine());
            for(int i=0;i <(trailRuns); i++){
                 bankSkill =bankSelected;
                 Random rnd = new Random();
                 bankSkill = rnd.Next(-10,10) + bankSkill;
                 if(teamSkill> bankSkill){
             /*  Console.WriteLine();
                Console.WriteLine("Success, you have pulled off a Heist");
                Console.WriteLine($"Team Skill: {teamSkill}");
                Console.WriteLine($"Bank Skill: {bankSkill}"); */
                successfulRuns ++;
            }
            else{ 
              /*  Console.WriteLine();
                Console.WriteLine("Failure, Your team is just too Weak");
                Console.WriteLine($"Team Skill: {teamSkill}");
                Console.WriteLine($"Bank Skill: {bankSkill}"); */
                badRuns++;
            }
            }
            Console.WriteLine();
            Console.WriteLine($"You have successfully completed {successfulRuns} trials and failed {badRuns} trails");
            Console.WriteLine("Are your ready for a real Heist? yes or no");
           string continueYes= Console.ReadLine();
            if(continueYes == "yes"){
                bankSkill =bankSelected;
                Random rndTwo = new Random();
                bankSkill = rndTwo.Next(-10,10) + bankSkill;
                 if(teamSkill> bankSkill){
               Console.WriteLine();
                Console.WriteLine("Success, you have pulled off a Heist");
                Console.WriteLine($"Team Skill: {teamSkill}");
                Console.WriteLine($"Bank Skill: {bankSkill}");
            }
            else{ 
                Console.WriteLine();
                Console.WriteLine("Failure, Your team is just too Weak");
                Console.WriteLine($"Team Skill: {teamSkill}");
                Console.WriteLine($"Bank Skill: {bankSkill}");
            }

            }
            else{
                Console.WriteLine("Thats probably smart, You could use a stronger team");
            }

        }
    }
}
