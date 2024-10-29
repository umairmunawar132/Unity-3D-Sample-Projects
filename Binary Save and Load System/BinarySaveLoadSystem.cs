using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class BinarySaveLoadSystem
{
	static string PersistantPath => Application.persistentDataPath + "/player.data";

	public static void SavePlayerData(PlayerData playerData, string path = "")
	{
		if (string.IsNullOrEmpty(path))
		{
			path = PersistantPath;
		}

		BinaryFormatter binaryFormatter = new BinaryFormatter();
		FileStream fileStream = new FileStream(path, FileMode.Create);
		binaryFormatter.Serialize(fileStream, playerData);
		fileStream.Close();
	}

	public static PlayerData LoadPlayerData(string path = null)
	{
		if (string.IsNullOrEmpty(path))
		{
			path = PersistantPath;
		}

		if (File.Exists(path))
		{
			Debug.LogError($"No file found on this path: {path}");
			return null;
		}

		BinaryFormatter binaryFormatter = new BinaryFormatter();
		FileStream fileStream = new FileStream(path, FileMode.Open);
		PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
		fileStream.Close();
		return playerData;
	}
}