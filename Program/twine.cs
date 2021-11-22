using System;
using System.Collections.Generic;

namespace Program
{
    public class TwineOrder
    {
        public List<string> twineList = new List<string>();

        public void twineProperties() {
            
            Console.WriteLine("Vilken färg ska vara på godiset: ");
            string twineColor = Console.ReadLine();

            Console.WriteLine("Vilket längd ska snöret vara: ");
            string twineLength = Console.ReadLine();


            candyAdd(twineColor, twineLength);
        }

        public void candyAdd(string twineColor, string twineLength) 
        {
            twineList.Add(twineColor);
            twineList.Add(twineLength);
        }
    }
}