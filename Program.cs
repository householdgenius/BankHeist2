using System;
using System.Collections.Generic;
namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker()
            {
                Name = "Joe",
                SkillLevel = 10,
                PercentageCut = 20
            };
            Hacker John = new Hacker()
            {
                Name = "John",
                SkillLevel = 15,
                PercentageCut = 25
            };
            Muscle Bob = new Muscle()
            {
                Name = "Bob",
                SkillLevel = 10,
                PercentageCut = 20
            };
            Muscle Bill = new Muscle()
            {
                Name = "Bill",
                SkillLevel = 15,
                PercentageCut = 25
            };
            LockSpecialist Sarah = new LockSpecialist()
            {
                Name = "Sarah",
                SkillLevel = 10,
                PercentageCut = 20
            };
            LockSpecialist Sue = new LockSpecialist()
            {
                Name = "Sue",
                SkillLevel = 10,
                PercentageCut = 20
            };
         List<IRobber> rolodex = new List<IRobber>
         {
            Joe, John, Bob, Bill, Sarah, Sue
         };  
         foreach(IRobber robbers in rolodex){
         Console.WriteLine($"Current Heist Operatives{rolodex.Count}");
         Console.WriteLine($"Pick a Crew Member: ");
         var NewCrewMember = Console.ReadLine();
        Console.WriteLine($"{NewCrewMember}");
         }
        }
    }
}
