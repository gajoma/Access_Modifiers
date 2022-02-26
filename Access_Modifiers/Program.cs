using System;

namespace Access_Modifiers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PPP test = new PPP();
            
            test.Offentlig();
            test.Privat();
            test.Intern();
            Beskyttet();


        }
    }
}
