using System;

namespace MasterMindGame
{
	public static class DisplayGame
	{
		public static void DisplayIntro()
		{
			Console.WriteLine("Welcome Human To MasterMind!");
			Console.WriteLine("You need to guess the 4 digit color code to save your planet!");
			Console.WriteLine("You have 6 colors to make a 4 digit code and 10 chances... ");
			Console.WriteLine("After that the laser will go off directly!");
			Console.WriteLine("May the new Gods and the old be with you!");
			Console.WriteLine(
				"Input color codes-- O: Orange, R:red, B:Blue, P:Purple, Y:Yellow and G:Green");
		}

		public static void DisplayCode()
			=> Console.WriteLine(
				"Input color codes-- O: Orange, R:red, B:Blue, P:Purple, Y:Yellow and G:Green");

		public static void DisplayOutro(int path)
		{
			if (path == 0)
				Console.WriteLine("You were weak and Humanity as you know it has ended!");
			else
				Console.WriteLine("You saved the world! It will be much harder next time stupid Human!");
		}

		public static void DisplayState(string[] playerGuess, int[] feedback)
		{
			Console.WriteLine(
				$"Your guess: {playerGuess[0]} {playerGuess[1]} {playerGuess[2]} {playerGuess[3]}");
			Console.WriteLine($"Feedback: {feedback[0]} {feedback[1]} {feedback[2]} {feedback[3]} ");
		}
	}
}