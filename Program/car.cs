using System;
using System.Collections.Generic;

namespace Program
{
    public class CarOrder
    {
        public List<string> carList = new List<string>();

        public void carProperties() {
            
            Console.WriteLine("Vad är registreringsnumret på bilen: ");
            string carRegNum = Console.ReadLine();

            Console.WriteLine("Vad är färgen på bilen: ");
            string carColor = Console.ReadLine();

            Console.WriteLine("Vad är märket på bilen: ");
            string carModel = Console.ReadLine();

            carAdd(carRegNum, carColor, carModel);
        }

        public void carAdd(string carRegNum, string carColor, string carModel) 
        {
            carList.Add(carRegNum);
            carList.Add(carColor);
            carList.Add(carModel);
        }
    }
}