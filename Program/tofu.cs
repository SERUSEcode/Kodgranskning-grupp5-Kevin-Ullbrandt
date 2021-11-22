using System;
using System.Collections.Generic;

namespace Program
{
    public class TofuOrder
    {
        public List<string> tofuList = new List<string>();

        public void tofuProperties() {
            
            Console.WriteLine("Vilken volym ska vara på tofun: ");
            string tofuVolume = Console.ReadLine();

            Console.WriteLine("Vilket grydning ska vara på tofun: ");
            string tofuSpice = Console.ReadLine();


            tofuAdd(tofuVolume, tofuVolume);
        }

        public void tofuAdd(string tofuVolume, string tofuSpice) 
        {
            tofuList.Add(tofuVolume);
            tofuList.Add(tofuSpice);
        }
    }
}