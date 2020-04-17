using System;
using System.Linq;

namespace MasterMindGame
{
	public class Game
	{
		public Game() => CodeGenerator = new CodeMaker();
		public CodeMaker CodeGenerator { get; set; }

		public void PlayGame()
		{
			var code = CodeGenerator.MakeCode();
			var i = 0;
			DisplayGame.DisplayIntro();
			while (i < 10)
			{
				var guess = PlayerInput.InsertCode();
				var feedback = Utilities.GivePlayerFeedback(guess, code);
				DisplayGame.DisplayState(guess, feedback);
				if (feedback.Sum() == 8)
				{
					DisplayGame.DisplayOutro(1);
					break;
				}

				i++;
			}

			Console.WriteLine($"Correct Code: {code[0]},{code[1]},{code[2]},{code[3]}");
		}
	}
}