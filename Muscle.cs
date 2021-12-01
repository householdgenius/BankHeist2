using System;
using System.Collections.Generic;
namespace Heist2{
    public class Muscle: IRobber
    {
        public string Name{get; set;}
        public int SkillLevel{get; set;}
        public int PercentageCut{get; set;}
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore--;
            if(bank.VaultScore <= 0){
               Console.WriteLine( $"{Name} has knocked out the security guard!");
           }
           else{
             Console.WriteLine($"{Name} is fighting the security guard. Decreased security {SkillLevel}");
           }
        }
    }
}