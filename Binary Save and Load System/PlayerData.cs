[System.Serializable]
public class PlayerData
{
	public enum PlayerType
	{
		Soldier,
		Wizard,
		NPC,
		Boss
	}

	public string name;
	public int level;
	public int health;
	public PlayerType type;

	public PlayerData(string name, int level, int health, PlayerType type)
	{
		this.name = name;
		this.level = level;
		this.health = health;
		this.type = type;
	}
}