using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding a user prompt to enter name
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            //New instance of Robe class and set properties
            Robe newRobe = new Robe
            {
                Colors = new List<string> {"Red", "Orange", "Yellow", "Green", "Blue", "Purple"},
                Length = 56
            };

            //New instantance of Hat and set properties. Ask for more detail about how this works?
            //We are just hard coding the 2? We don't need the ShininessDescription because that is actually just a computed string for 
            //the Shininess level?
            Hat newHat = new Hat
            {
                ShininessLevel = 2
            };
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge("What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge("What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            // Make a new "Adventurer" object using the "Adventurer" class
            //*Phase2 - used name variable
            //*Phase4 - passed newRobe into the constructor of Adventurer
            Adventurer theAdventurer = new Adventurer(name, newRobe, newHat);

            Console.WriteLine(theAdventurer.GetDescription());

            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

            //*variable of gameReplay to repeat challenges
            bool gameReplay = true;

            //*While loop to re-loop challenges when user answers yes
            while (gameReplay)
            {

            // Loop through all the challenges and subject the Adventurer to them
            foreach (Challenge challenge in challenges)
            {
                challenge.RunChallenge(theAdventurer);
            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
            //*Phase3 Prompt to ask user to play again and used answer as variable
            Console.WriteLine("Would you like to play again? y/n.");
            string answer = Console.ReadLine();

            //*Phase3 if statement to end the game
                if (answer != "y")
                {
                    gameReplay = false;
                }
            }
        }
    }
}
