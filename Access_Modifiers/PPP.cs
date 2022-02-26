using System;

namespace Access_Modifiers
{
    public class PPP
    {
        private void Privat()
        {
            Console.WriteLine("Jeg er private");
        }

        public void Offentlig()
        {
            Console.WriteLine("Jeg er public");
            //Beskyttet();
            //Privat();
        }

        protected void Beskyttet()
        {
            Console.WriteLine("Jeg er protected");
        }

        internal void Intern()
        {
            Console.WriteLine("Jeg er internal");
        }
    }
}