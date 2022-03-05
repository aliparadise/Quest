using System;

namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        // A constructor to make a new Adventurer object with a given name
        //*added colorsOfTheRobe parameter and set the colorfulrobe property
        //*added shinyHat parameter and set the shineyHat property
        public Adventurer(string adventurerName, Robe colorsOfTheRobe, Hat shinyHat)
        {
            Name = adventurerName;
            Awesomeness = 50;
            Robe = colorsOfTheRobe;
            Hat = shinyHat;
        }
        //*added immutible property ColorfulRobe to the Adventurer class with a type of Robe
        //*added immutible property shineyHat to the Adventurer class with a type of Hat
        public Robe Robe { get; }

        public Hat Hat { get; }

        //method that returns a description of the adventurer
        public string GetDescription()
        {
            return $"The Adventurer {Name} has a {String.Join(", ", Robe.Colors)} robe that is {Robe.Length} inches long, and a {Hat.ShininessDescription} hat.";
        }



        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }
    }
}