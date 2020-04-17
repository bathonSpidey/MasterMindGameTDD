using MasterMindGame;
using NUnit.Framework;

namespace MasterMindGameTests
{
	public class Tests
	{

		[Test]
		public void CheckName()
		{
			Player one=new Player();
			Player two=new Player("Spidey");
			Assert.AreEqual("DeepMind",one.Name);
			Assert.AreEqual("Spidey",two.Name);
		}
	}
}