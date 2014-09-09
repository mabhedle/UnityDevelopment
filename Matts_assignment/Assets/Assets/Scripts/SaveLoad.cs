using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{
	public static Game game;
	
	public static void Save()
	{
		//savedGames.Add(Game.current);
		
		BinaryFormatter bf = new BinaryFormatter();
		
		FileStream file = File.Create(Application.persistentDataPath+"/savedGames.gd");
		bf.Serialize(file,SaveLoad.game);
		file.Close();
	}
	
	public static void Load() 
	{
    	if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
        SaveLoad.game = (Game)bf.Deserialize(file);
        file.Close();
    }
}
	
}