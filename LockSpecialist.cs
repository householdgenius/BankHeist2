using System;
using System.Collections.Generic;
namespace Heist2{
    public class LockSpecialist: IRobber
    {
        public string Name{get; set;}
        public int SkillLevel{get; set;}
        public int PercentageCut{get; set;}

        public LockSpecialist(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore--;
            if(bank.VaultScore <= 0){
               Console.WriteLine( $"{Name} has unlocked the vault!");
           }
           else{
             Console.WriteLine($"{Name} is unlocking the vault. Decreased security {SkillLevel}");
           }
        }
    }
}