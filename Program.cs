using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistPart2
{
  class Program
  {
    static void Main(string[] args)
    {

      var rolodex = new List<IRobber>();

      var Jay = new Hacker()
      {
        Name = "Jay",
        SkillLevel = 30,
        PercentageCut = 60
      };

      var Greg = new Hacker()
      {
        Name = "Greg",
        SkillLevel = 50,
        PercentageCut = 70
      };

      var Fee = new Muscle()
      {
        Name = "Fee",
        SkillLevel = 30,
        PercentageCut = 60
      };

      var Noob = new Muscle()
      {
        Name = "Noob",
        SkillLevel = 60,
        PercentageCut = 40
      };

      var Stu = new LockSpecialist()
      {
        Name = "Stu",
        SkillLevel = 30,
        PercentageCut = 70
      };

      var MiMi = new LockSpecialist()
      {
        Name = "MiMi",
        SkillLevel = 80,
        PercentageCut = 40
      };

      rolodex.Add(Jay);
      rolodex.Add(Greg);
      rolodex.Add(Fee);
      rolodex.Add(Noob);
      rolodex.Add(Stu);
      rolodex.Add(MiMi);




      while (true)
      {
        Console.WriteLine($"We have {rolodex.Count} crew members.");
        Console.WriteLine($"Enter a new crew member?");
        var crewMemberName = Console.ReadLine();
        if (crewMemberName == "")
        { break; }
        else
        {
          // Pick Member Specialty
          Console.WriteLine($"What is {crewMemberName}'s Specialty?");
          Console.WriteLine("Hacker (Disables Alarms)");
          Console.WriteLine("Muscle (Disable Guards");
          Console.WriteLine("Lock Specialist (Disables Vaults)");
          var crewSpecialty = Console.ReadLine().ToLower();

          while (true)
          {

            if (crewSpecialty == "muscle" || crewSpecialty == "hacker" || crewSpecialty == "lock specialist")
            { break; }

          }
          Console.WriteLine($"What is {crewMemberName}'s skill level? (1-100");
          int newMemberSkillLevel;


          while (true)
          {
            newMemberSkillLevel = int.Parse(Console.ReadLine());
            { break; }

          }

          Console.WriteLine($"What percentage of the cut does {crewMemberName}");
          int crewMemberCut;

          while (true)
          {
            crewMemberCut = int.Parse(Console.ReadLine());
            { break; }
          }

          if (crewSpecialty == "hacker")
          {
            Hacker hacker = new Hacker()
            {
              Name = $"{crewMemberName}",
              SkillLevel = newMemberSkillLevel,
              PercentageCut = crewMemberCut
            };
            rolodex.Add(hacker);
          }
          else if (crewSpecialty == "muscle")
          {
            Muscle muscle = new Muscle()
            {
              Name = $"{crewMemberName}",
              SkillLevel = newMemberSkillLevel,
              PercentageCut = crewMemberCut
            };
            rolodex.Add(muscle);
          }
          else if (crewSpecialty == "lock specialist")
          {
            LockSpecialist lockSpecialist = new LockSpecialist()
            {
              Name = $"{crewMemberName}",
              SkillLevel = newMemberSkillLevel,
              PercentageCut = crewMemberCut
            };
            rolodex.Add(lockSpecialist);
          }

          // randomized variables for bank
          int alarmScore = new Random().Next(0, 101);
          int vaultScore = new Random().Next(0, 101);
          int securityGuardScore = new Random().Next(0, 101);
          int cashOnHand = new Random().Next(50000, 1000001);

          Console.WriteLine($"cashOnHand {cashOnHand}");

          Bank bank = new Bank()
          {
            AlarmScore = alarmScore,
            VaultScore = vaultScore,
            SecurityGuardScore = securityGuardScore,
            CashOnHand = cashOnHand
          };
          Console.WriteLine($"Your crew has {rolodex.Count} members");

          Dictionary<string, int> scores = new Dictionary<string, int>();
          scores.Add("Alarm", alarmScore);
          scores.Add("Vault", vaultScore);
          scores.Add("Security Guard", securityGuardScore);

          var ascendingScores = scores.OrderBy(score => score.Value);

          var lowestScore = ascendingScores.First();

          var highestScore = ascendingScores.Last();

          Console.WriteLine("---------------------------------");

          Console.WriteLine($"Most Secure: {highestScore.Key}");

          Console.WriteLine($"Least Secure: {lowestScore.Key}");

          Console.WriteLine("-------------------------------------");

          foreach (var robber in rolodex)
          {
            Console.WriteLine($"{rolodex.IndexOf(robber)}: {robber.Name} {robber.SkillLevel} {robber.PercentageCut}");

          }

          var crew = new List<IRobber>();

          double totalCutPercentage = 100;


          while (true)
          {
            try
            {
              // makes console more user friendly
              Console.WriteLine("");

              Console.WriteLine("Which robber would you like to add to your crew? (Index integer or press enter to continue)");
              //Check to see if nothing is entered
              var chosenMember = Console.ReadLine();
              if (chosenMember == "")
              {
                break;
              }
              else
              {
                foreach (var item in rolodex)
                {
                  if (int.Parse(chosenMember) == rolodex.IndexOf(item))
                  {

                    crew.Add(item);
                    totalCutPercentage -= item.PercentageCut;
                    Console.WriteLine($"Cut left: {totalCutPercentage}");
                    rolodex.Remove(item);
                    break;

                  }
                }
                foreach (var item in rolodex)
                {
                  if (item.PercentageCut < totalCutPercentage)
                  {
                    Console.WriteLine($"{rolodex.IndexOf(item)} {item.ToString()}");
                  }


                  // var robberIndex = int.Parse(robberIndexString);

                  // if (robberIndex < rolodex.Count || robberIndex >= 0)
                  // {
                  //   //Add member to your crew
                  //   crew.Add(rolodex[robberIndex]);
                  //   //Subtract added member's percentage cut from crewCutPercentageLeft
                  //   crewCutPercentageLeft -= rolodex[robberIndex].PercentageCut;
                  //   //Remove new crew member from rolodex
                  //   rolodex.Remove(rolodex[robberIndex]);
                }
                //   else
                // {
                //   Console.WriteLine("Please enter a valid index integer");
                // }
              }

            }
            catch
            {
              Console.WriteLine("Invalid input. Please enter a valid index integer");
            }


            // Makes the console a bit more user-friendly by adding a break in the terminal
            Console.WriteLine("");
            // Display the securities again for better user experience
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Most secure: {highestScore.Key}");
            Console.WriteLine($"Least secure: {lowestScore.Key}");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Robbers available to add to your crew:");
            //  Display who's left you're able to add
            foreach (var robber in rolodex)
            {
              if (totalCutPercentage - robber.PercentageCut >= 0)
              {
                Console.WriteLine($"{rolodex.IndexOf(robber)}: {robber}");
              }
            }
          }

          // Have each crew member in your crew perform their skill on the bank
          foreach (var crewMember in crew)
          {
            crewMember.PerformSkill(bank);
          }

          // Makes the console a bit more user-friendly by adding a break in the terminal
          Console.WriteLine("");

          // Check to see if the bank is still secure after the heist
          if (bank.IsSecure)
          {
            // Failure message:
            Console.WriteLine("Unfortunately everyone's hard work didn't pay off. Don't quit your day jobs!");
          }
          else
          {
            // Success message and report:
            Console.WriteLine($"Success! Your crew managed to get away with ${cashOnHand}!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Everyone gets their piece of the pie:");
            Console.WriteLine("--------------------------------------");
            foreach (var crewMember in crew)
            {
              // Calculate how much each crew member gets from the heist
              double cut = (crewMember.PercentageCut * cashOnHand) / 100;
              Console.WriteLine($"{crewMember.Name} walks away with ${cut}!");
            }
            // Makes the console a bit more user-friendly by adding a break in the terminal
            Console.WriteLine("");
            // Calculate what you walk away with for setting up the heist!
            double leftover = (totalCutPercentage * cashOnHand) / 100;
            Console.WriteLine($"For setting up the heist you get what's leftover and walk away with ${leftover}. Good job!");
          }
        }
      }
    }
  }
}

















