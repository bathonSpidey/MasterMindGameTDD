using System;

namespace MasterMindGame
{
	public static class PlayerInput
	{
		public static string[] InsertCode()
		{
			var needCode = new CodeMaker();
			string[] playerInput = { "_", "_", "_", "_" };
			string colorCode;
			var code = needCode.ColorPins;
			for (var i = 0; i < 4; i++)
				while (true)
				{
					Console.Write($"Enter color code in position {i + 1} : ");
					colorCode = Console.ReadLine();
					if (Array.Exists(code, element => element == colorCode.ToUpper()))
					{
						playerInput[i] = colorCode.ToUpper();
						break;
					}

					Console.WriteLine("Wrong Color Code Human! We do not have all day!");
					DisplayGame.DisplayCode();
				}

			return playerInput;
		}
	}
}