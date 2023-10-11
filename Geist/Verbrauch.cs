using System;
namespace Geist
{
	public class Verbrauch
	{
		//public static void Main(string[] args)
		//{
		//	int[] kilometer = { 123, 134, 120, 122 };
		//	Console.WriteLine("Durchschnittlicher Verbrauch: " + DurschnittlicherVerbrauch(kilometer));
  //      }

		public static float DurschnittlicherVerbrauch(int[] kilometer)
		{
			float gesamtstrecke= 0.0f;
			foreach(int fahrt in kilometer)
			{
				gesamtstrecke += fahrt;
			}
			return gesamtstrecke / kilometer.GetLength(0);
		}
	}
}

