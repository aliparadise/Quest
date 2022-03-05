using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize (string text) {
            _text = text;
        }

        //this is a method called ShowPrize with Adventurer as a parameter. 
        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                Console.WriteLine(_text);
            }
            else if (adventurer.Awesomeness <= 0)
            {
                Console.WriteLine("Sorry, you have not won a prize.");
            }
        }
    }
}