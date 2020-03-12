using System;

namespace HeistPart2
{
  public class Muscle : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }

    public int PercentageCut { get; set; }

    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Bank Vault Score: {bank.SecurityGuardScore}");
      Console.WriteLine($"SkillLevel: {SkillLevel}");
      Console.WriteLine($"{Name} is picking the lock on the vault.");

      if (bank.SecurityGuardScore - SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has disabled the vault door.");
      }
      else
      {
        Console.WriteLine($"{Name} has failed.");
      }
    }

    // Constructor
    //   public Muscle(string name, int skillLevel, int percentageCut)
    //   {
    //     Name = name;
    //     SkillLevel = skillLevel;
    //     PercentageCut = percentageCut;
    //   }
  }

}