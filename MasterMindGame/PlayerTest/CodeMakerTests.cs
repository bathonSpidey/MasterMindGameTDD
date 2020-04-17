using MasterMindGame;
using NUnit.Framework;

namespace MasterMindGameTests
{
	public class CodeMakerTests
	{
		[Test]
		public void CodeConstructorTest()
		{
			CodeMaker masterMind=new CodeMaker();
			Assert.AreEqual("B",masterMind.ColorPins[0]);
			Assert.AreEqual("O",masterMind.ColorPins[5]);
		}

		[Test]
		public void GeneratedCodeLength()
		{
			CodeMaker masterMind=new CodeMaker();
			string[] code = masterMind.MakeCode();
			Assert.AreEqual(4,code.Length);
		}
	}
}
