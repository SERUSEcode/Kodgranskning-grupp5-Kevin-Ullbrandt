using System;
using System.Collections.Generic;

namespace Program
{
    public class CandyOrder
    {
        public List<string> candyList = new List<string>();

        public void candyProperties() {
            
            Console.WriteLine("Vilken smak ska vara på godiset: ");
            string candyTaste = Console.ReadLine();

            Console.WriteLine("Vilket antal vill du ha utav godiset: ");
            string candyAmount = Console.ReadLine();


            candyAdd(candyTaste, candyAmount);
        }

        public void candyAdd(string candyTaste, string candyAmount) 
        {
            candyList.Add(candyTaste);
            candyList.Add(candyAmount);
        }
    }
}