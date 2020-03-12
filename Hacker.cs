using System;
using System.Collections.Generic;

namespace HeistPart2
{
  public class Hacker : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }

    public int PercentageCut { get; set; }

    // Method
    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Bank Vault Score: {bank.AlarmScore}");
      Console.WriteLine($"SkillLevel: {SkillLevel}");
      Console.WriteLine($"{Name} is picking the lock on the vault.");

      if (bank.AlarmScore - SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has disabled the vault door.");
      }
      else
      {
        Console.WriteLine($"{Name} has failed.");
      }
    }




    // Constructor
    // public Hacker(string name, int skillLevel, int percentageCut)
    // {
    //   Name = name;
    //   SkillLevel = skillLevel;
    //   PercentageCut = percentageCut;
    // }




  }

}
