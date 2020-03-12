using System;
using System.Collections.Generic;

namespace HeistPart2
{
  class Program
  {
    static void Main(string[] args)
    {

      var rolodex = new List<IRobber>();

      // Hacker HJay = new Hacker("Jay", 10, 10);
      // Hacker HGreg = new Hacker("Greg", 15, 15);
      // Muscle MFee = new Muscle("Fee", 13, 8);
      // Muscle MNoob = new Muscle("Noob", 20, 17);
      // LockSpecialist LStu = new LockSpecialist("Stu", 9, 25);
      // LockSpecialist LMiMi = new LockSpecialist("MiMi", 5, 30);

      // rolodex.Add(HJay);
      // rolodex.Add(HGreg);
      // rolodex.Add(MFee);
      // rolodex.Add(MNoob);
      // rolodex.Add(LStu);
      // rolodex.Add(LMiMi);

      Console.WriteLine($"We have {rolodex.Count} crew members.");



      while (true)
      {
        Console.WriteLine($"Enter a new crew member?");
        string crewMemberName = Console.ReadLine();
        // var rolodex = new List<IRobber>();

        if (crewMemberName == "")
        { break; }
        else
        {

          Console.Write("What is their Specialty? Muscle, Hacker, or Lock Specialist");
          var crewSpecialty = Console.ReadLine();

          while (true)
          {
            l

            if (crewSpecialty.ToLower() == "muscle")
            {
              var newMuscle = new Muscle()
              {
                Name = crewMemberName
              };
              Console.WriteLine("Enter crew member's skill level (1-100)");
              var memberSkillLevel = Console.ReadLine();
              newMuscle.SkillLevel = int.Parse(memberSkillLevel);
              Console.WriteLine("Enter crew member's percentage cut (1-100)");
              var memberPercentageCut = Console.ReadLine();
              newMuscle.PercentageCut = int.Parse(memberPercentageCut);
              rolodex.Add(newMuscle);
              break;

            }
            else
            {

              if (crewSpecialty.ToLower() == "hacker")
              {
                Hacker newHacker = new Hacker()
                {
                  Name = crewMemberName
                };
                Console.WriteLine("Enter crew member's skill level (1-100)");
                var memberSkillLevel = Console.ReadLine();
                newHacker.SkillLevel = int.Parse(memberSkillLevel);
                Console.WriteLine("Enter crew member's percentage cut (1-100)");
                var memberPercentageCut = Console.ReadLine();
                newHacker.PercentageCut = int.Parse(memberPercentageCut);
                rolodex.Add(newHacker);
                break;
              }

              if (crewSpecialty.ToLower() == "lock specialist")
              {
                LockSpecialist newLockSpecialist = new LockSpecialist()
                {
                  Name = crewMemberName
                };
                Console.WriteLine("Enter crew member's skill level (1-100)");
                var memberSkillLevel = Console.ReadLine();
                newLockSpecialist.SkillLevel = int.Parse(memberSkillLevel);
                Console.WriteLine("Enter crew member's percentage cut (1-100)");
                var memberPercentageCut = Console.ReadLine();
                newLockSpecialist.PercentageCut = int.Parse(memberPercentageCut);
                rolodex.Add(newLockSpecialist);
                break;
              }








            }



          }

        }






      }
    }
  }
}