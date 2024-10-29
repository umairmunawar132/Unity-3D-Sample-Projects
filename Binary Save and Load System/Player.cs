using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Player : MonoBehaviour
{
	public string playerName;
	public int level;
	public int health;
	public PlayerData.PlayerType type;

	void Start()
	{
		LoadPlayerData();
	}

	void LoadPlayerData()
	{
		PlayerData playerData = BinarySaveLoadSystem.LoadPlayerData();
		playerName = playerData.name;
		type = playerData.type;
		level = playerData.level;
		health = playerData.health;
	}

	void SavePlayerData()
	{
		BinarySaveLoadSystem.SavePlayerData(new PlayerData(playerName, level, health, type));
	}
}