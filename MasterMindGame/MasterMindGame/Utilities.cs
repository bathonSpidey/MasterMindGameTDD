using System;

namespace MasterMindGame
{
	public static class Utilities
	{
		public static int[] GivePlayerFeedback(string[] guess, string[] code)
		{
			var feedback = new int[4];
			for (var i = 0; i < 4; i++)
				if (Array.Exists(code, element => element == guess[i]))
					if (guess[i] == code[i])
						feedback[i] = 2;
					else
						feedback[i] = 1;
				else
					feedback[i] = 0;
			Array.Sort(feedback);
			Array.Reverse(feedback);
			CheckDuplicates(guess, code, feedback);
			return feedback;
		}

		private static void CheckDuplicates(string[] guess, string[] code, int[] feedback)
		{
			var trackOwn = 0;
			var trackWithCode = 0;
			var count = 0;
			for (var i = 0; i < guess.Length; i++)
			{
				for (var j = 0; j < guess.Length; j++)
				{
					if (guess[i] == code[j])
						trackWithCode++;
					if (guess[i] == guess[j])
						trackOwn++;
				}

				if (trackOwn - trackWithCode >= 1 && trackWithCode>0)
				{
					var index = Array.IndexOf(feedback, 1);
					if (index >= 0 && count == 0)
					{
						feedback[index] = 0;
						count++;
					}
					else
					{
						count = 0;
					}
				}

				trackOwn = 0;
				trackWithCode = 0;
			}
			Array.Sort(feedback);
			Array.Reverse(feedback);
		}
	}
}