namespace MasterMindGame
{
	public class Player
	{
		public Player() : this("DeepMind") { }

		public Player(string name) => Name = name;

		public string Name { get; set; }
	}
}