using System.IO;
using UnityEngine;

public class LocalizationFileManager : MonoBehaviour
{
    private static string LocalesPath = Application.dataPath + "/locales/";

    //File writer, later use
    //public static void WriteString()
    //{
    //    string path = Application.persistentDataPath + "/test.txt";
    //    //Write some text to the test.txt file
    //    StreamWriter writer = new StreamWriter(path, true);
    //    writer.WriteLine("Test");
    //    writer.Close();
    //    StreamReader reader = new StreamReader(path);
    //    //Print the text from the file
    //    Debug.Log(reader.ReadToEnd());
    //    reader.Close();
    //}

    public static void ReadString()
    {
        string path = Application.persistentDataPath + "/test.txt";

        StreamReader reader = new StreamReader(LocalesPath + "");
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    public static string GetTranslationLineFromFile(string language, string refname)
    {
        string ret = null;
        var lines = File.ReadAllLines(LocalesPath + language + ".locale");
        foreach (var line in lines)
        {
            if (line.Trim().Contains(refname))
            {
                ret = line;
            }
        }
        return ret;
    }
}