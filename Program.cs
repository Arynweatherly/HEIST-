using System;

namespace HeistExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine();
            //declare variable  Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
            Heister teamMember;

            //Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("What is the team member's name?");
            string name = Console.ReadLine();

            //Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.WriteLine("What is the team member's skill level?");
            string skillLevelString = Console.ReadLine();
            int skillLevel;

            try
            {
                //put thing that might throw an exception in here
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{skillLevelString} is not a valud skill level. Using a default value of 10");
                skillLevel = 10;

            }

            //Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            Console.WriteLine("What is the team member's courage factor?");
            string courageFactorString = Console.ReadLine();
            decimal courageFactor;

            //set up try catch w/ this too

            try
            {
                courageFactor = decimal.Parse(courageFactorString);
            }
            catch (Exception)
            {

                Console.WriteLine($"{courageFactorString} is not a valid courgae factor. Using a default value of 1");
                courageFactor = 1.0M;
            }

            //what is value of team member rn?
            //nothing yet.. havent set it to anything

            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor,
            };
            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");
        }
    }
}