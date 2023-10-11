using System;
namespace Geist
{
	public class Geist
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Spiel der Geister");

			Random random = new Random();
			int behindDoor = random.Next(1, 6);
			bool[] besucht = { false, false, false, false, false };
			bool[] replay = besucht;
			int punkte = 0;
			bool geistNichtGefunden = true;
			int spielerEingabe;
			while (geistNichtGefunden)
			{
				do
				{
					spielerEingabe = Eingabe("Hinter einer der Türen versteckt sich der Geist. \n" +
						"Welche Tür möchtest du öffnen (1 bis 5 )?");
				} while (Geoeffnet(besucht, spielerEingabe));
				if (GeistVorhanden(behindDoor, spielerEingabe))
				{
					punkte++;
					besucht[spielerEingabe] = true;
				}
				geistNichtGefunden = GeistVorhanden(behindDoor, spielerEingabe);

				if(punkte%4 == 0)
				{
                    behindDoor = random.Next(1, 6);
                    besucht = replay;
                }
			}

			Verloren(punkte);
		}

		public static int Eingabe(string text)
		{
			Console.WriteLine(text);
			return Convert.ToInt32(Console.ReadLine());
		}

		public static bool Geoeffnet(bool[] besucht, int tuer)
		{
			if (besucht[tuer])
			{
				Console.WriteLine("Schon einmal eingegeben!");
				return besucht[tuer];
			}
			return besucht[tuer];
		}

		public static bool GeistVorhanden(int behindDoor, int spielerEingabe)
		{
			return behindDoor != spielerEingabe;
		}

		public static void Verloren(int punkte)
		{
			Console.WriteLine("Hier ist ein Geist!");
			Console.WriteLine($"Deine Punkte: {punkte}");
		}
	}
}

