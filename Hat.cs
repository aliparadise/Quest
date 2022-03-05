using System;


namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }

    //computed string property. We have to do the return vs console.writeline here...make sure you understand why?
        public string ShininessDescription 
        {
            get
            {
                if (ShininessLevel < 2) 
                {
                    return "dull";    
                }
                else if (ShininessLevel >= 2 && ShininessLevel <= 5)
                {
                    return "noticeable";
                }
                else if (ShininessLevel >= 6 && ShininessLevel <= 9)
                {
                    return "bright";
                }
                else 
                {
                    return "blinding";
                }
            }
        }
    }
}