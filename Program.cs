using System;
using System.Collections.Generic;
namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker("Joe", 10,20);
            Hacker John = new Hacker("John", 15,25);
            Muscle Bob = new Muscle("Bob", 10,20);
            Muscle Bill = new Muscle("Bill", 15,25);
            LockSpecialist Sarah = new LockSpecialist("Sarah",10,20);
            LockSpecialist Sue = new LockSpecialist("Sue",10,20);
            List<IRobber> rolodex = new List<IRobber>
         {
            Joe, John, Bob, Bill, Sarah, Sue
         };
         AddCrewMember();
         
            void AddCrewMember(){
            Console.WriteLine($"Current Heist Operatives {rolodex.Count}");
            Console.WriteLine($"Pick a Crew Member: ");
            var NewCrewMember = Console.ReadLine();
           if(NewCrewMember != ""){
            Console.WriteLine($"{NewCrewMember} can be 1 -Hacker(Disables Alarms), 2 -Muscle(Disarms Guards) 3 -LockSpecialist(cracks vaults) ");
            var thief = int.Parse(Console.ReadLine());
            string[] thiefTypes = new string[] { "Null","Hacker", "Muscle", "LockSpecialist" };
            var thiefType = thiefTypes[thief];
            Console.WriteLine($"{NewCrewMember} is a {thiefType}");
            Console.WriteLine($"What will {NewCrewMember}'s skill level be? (1-100)");
            var skillLevel = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{NewCrewMember} has a skill level of {skillLevel}");
            Console.WriteLine($"What percentage cut does {NewCrewMember} want to recieve?");
            var percentageCut = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{NewCrewMember} will recieve {percentageCut}% of the heist earnings");
            if(thief == 1){
           Hacker newHacker = new Hacker(NewCrewMember,skillLevel,percentageCut);
           rolodex.Add(newHacker);
            }
            else if(thief ==2 ){
            rolodex.Add(new Muscle(NewCrewMember,skillLevel,percentageCut));
            }
            else{
            rolodex.Add(new LockSpecialist(NewCrewMember,skillLevel,percentageCut));
            }
            Console.WriteLine("Add another Member?(Y/N): ");
            var answer = Console.ReadLine().ToLower();
            if(answer=="y"){
                AddCrewMember();
            }
           }
           }
            }
        }
    }

