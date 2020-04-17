using MasterMindGame;
using NUnit.Framework;

namespace MasterMindGameTests
{
	public class UtilitiesTests
	{
		[Test]
		public void AllWrong()
		{
			var code = new[] { "Y", "Y", "Y", "Y" };
			var guess = new[] { "O", "B", "G", "R" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 0, 0, 0, 0 };
			Assert.AreEqual(expected, feedback);
		}

		[Test]
		public void WrongPositions()
		{
			var code = new[] { "O", "B", "G", "R" };
			var guess = new[] { "B", "O", "R", "G" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 1, 1, 1, 1 };
			Assert.AreEqual(expected, feedback);
		}

		[Test]
		public void AllRight()
		{
			var code = new[] { "O", "B", "G", "R" };
			var guess = new[] { "O", "B", "G", "R" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 2, 2, 2, 2 };
			Assert.AreEqual(expected, feedback);
		}

		[Test]
		public void OnlyOneGuessRight()
		{
			var code = new[] { "O", "B", "G", "R" };
			var guess = new[] { "Y", "O", "Y", "Y" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 1, 0, 0, 0 };
			Assert.AreEqual(expected,feedback);
		}

		[Test]
		public void OnlyOneGuessWithPositionRight()
		{
			var code = new[] { "O", "B", "G", "R" };
			var guess = new[] { "Y", "B", "Y", "Y" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 2, 0, 0, 0 };
			Assert.AreEqual(expected,feedback);
		}
		[Test]
		public void DuplicateTest()
		{
			var code = new[] { "O", "B", "R", "Y" };
			var guess = new[] { "Y", "Y", "G", "G" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 1, 0, 0, 0 };
			Assert.AreEqual(expected,feedback);
		}
		[Test]
		public void DuplicateTestPORY()
		{
			var code = new[] { "P", "O", "R", "Y" };
			var guess = new[] { "R", "R", "G", "G" };
			var feedback = Utilities.GivePlayerFeedback(guess, code);
			var expected = new[] { 1, 0, 0, 0 };
			Assert.AreEqual(expected,feedback);
		}
	}
}