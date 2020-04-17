using System;

namespace MasterMindGame
{
	public class CodeMaker
	{
		public CodeMaker()
			=> ColorPins = new[]
			{
				"B", "G", "R", "Y",
				"P", "O"
			}; //Blue, Green, Red, Yellow, Purple, Orange

		public string[] ColorPins { get; }

		public string[] MakeCode()
		{ 
			string[] code = new string[4];
			Random random=new Random();
			int randomNumber;
			for (int i = 0; i < 4; i++)
			{
				randomNumber = random.Next(6);
				code[i] = ColorPins[randomNumber];
			}

			return code;
		}
}

}