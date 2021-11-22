using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOrder = new CarOrder();
            var candyOrder = new CandyOrder();
            var twineOrder = new TwineOrder();
            var tofuOrder = new TofuOrder();
            
            while(true) {

                //Meny
                Console.Clear();
                Console.WriteLine("Vällkomen till Multifabriken!" + "\n" + "Här tillverkar vi bilar, godis, snören och även tofu. \n" + 
                "I konsolen nedan kan du välja vilka produkter du vill beställa. Mer information kommer efter du har valt!" +
                "\n\n" +
                "[1] Bilar\n" +
                "[2] Godis\n" +
                "[3] Snören\n" +
                "[4] Tofu\n" +
                "[5] Lista alla beställda produkter\n" +
                "[q] Avsluta program"
                );
                string inputMenu = Console.ReadLine();

                switch (inputMenu) {
                    case "1": //cars

                        carOrder.carProperties();

                    break;
                    case "2": //candy

                        candyOrder.candyProperties();

                    break;
                    case "3": //twine

                        twineOrder.twineProperties();

                    break;
                    case "4": //tofu

                        tofuOrder.tofuProperties();

                    break;
                    case "5": //list object

                    int countCar = 0;
                    int countCandy = 0;
                    int countTwine = 0;
                    int countTofu = 0;

                        for (int i = 0; i < carOrder.carList.Count; i = i + 3) {

                            Console.WriteLine("" +
                            "\nRegisteringsnumer: " + carOrder.carList[i] + 
                            "\nFärg på bilen: " + carOrder.carList[i + 1] +
                            "\nMärke på bilen: " + carOrder.carList[i + 2]);
                        }

                        for (int i = 0; i < candyOrder.candyList.Count; i = i + 2) {

                            Console.WriteLine("Smak på godiset: " + carOrder.carList[i] + 
                            "\nAntal av godis: " + carOrder.carList[i + 1]);
                        }

                        for (int i = 0; i < twineOrder.twineList.Count; i = i + 2) {

                            Console.WriteLine("Färg på snöret: " + twineOrder.twineList[i] + 
                            "\nLängd på snöret: " + twineOrder.twineList[i + 1]);
                        }

                        for (int i = 0; i < tofuOrder.tofuList.Count; i = i + 2) {

                            Console.WriteLine("Volym på tofun: " + tofuOrder.tofuList[i] + 
                            "\nKryddning på tofun: " + tofuOrder.tofuList[i + 1]);
                        }
                        
                        Console.WriteLine("Klicka [ENTER] för att fortsätta till menyn");
                        Console.ReadLine();

                    break;
                    case "q": //quit program

                    break;
                    default:
                        Console.WriteLine("Erro: fel inmatning. Mata in siffra 1-5 eller q för att avsluta program");
                        
                    break;
                }
            }
        }
    }
}
