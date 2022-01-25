using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSys : MonoBehaviour
{
    public static string SaveFilePath;
    private void Awake()
    {
        SaveFilePath = Application.persistentDataPath + "/save.data";
    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private GameData CreateSaveGameObject()
    {
        GameData save = new GameData();

        save.GameLanguage = LocalizationManager.Language;

        return save;
    }
    public void SaveGame()
    {
        GameData save = CreateSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(SaveFilePath);
        bf.Serialize(file, save);
        file.Close();


        Debug.Log("Game Saved");
    }

    public void LoadGame()
    {
        if (File.Exists(SaveFilePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(SaveFilePath, FileMode.Open);
            GameData save = (GameData)bf.Deserialize(file);
            file.Close();

            LocalizationManager.Language = save.GameLanguage;

            Debug.Log("Game Loaded ." + save.GameLanguage);
        }
        else
        {
            Debug.Log("Can't find save file.");
        }
    }

}
