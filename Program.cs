using System;
using System.Collections.Generic;
using Tama;

namespace dagens_demo
{
    class Program
    {
        static void Main(string[] args)
        {
			//PassByReferenceDemo.RunTest();

            // Tamagotichi
			//
			// Kunna mata tamag.
			// Rasta.
			// Städa efter den.
			// Trösta den om den är ledsen.
			// Leka.
			// ...☠️
			// Flytta den mellan olika områden
			// Lekplats, Sovrum, Resturang
			List<Tamagotchi> gotchis = new List<Tamagotchi>();
			Room testRoom = new Bedroom();
			gotchis.Add(new YellowGotchi(testRoom));
			gotchis.Add(new RedGotchi());

			foreach(Tamagotchi tama in gotchis) {
				tama.Wait();

				if (tama.Dead) {
					Console.WriteLine("Dog");
				} else {
					if (tama.Hungry) {
						Console.WriteLine("Är hungrig");
					}
				}
			}
        }
    }
}
