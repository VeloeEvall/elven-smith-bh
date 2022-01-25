using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class LocalizationManager
{
    private static string _lang = null;

    [SerializeField]
    public static string Language
    {
        get { return _lang; }
        set { _lang = value; }
    }

    private static List<string> _references = new List<string>();

    public static List<string> GetReferences()
    {
        var referencepath = Application.dataPath + "/locales/references.cnf";
        var lines = File.ReadAllLines(referencepath);
        foreach (var line in lines)
        {
            if (line.Trim() != string.Empty)
            {
                _references.Add(line);
            }
        }

        return _references;
    }

    public static void ApplyLocalisation(GameObject caller, TMPro.TMP_Text TMPTextSource = null, UnityEngine.UI.Text TextSource = null, string ReferenceName = null)
    {
        if (TMPTextSource != null)
        {
            if (ReferenceName != null)
            {
                TMPTextSource.text = Localise(ReferenceName, LocalizationManager.Language);
            }
            else
            {
                Debug.LogError("Reference name not set. For: '" + caller.name + "'.");
            }
        }
        else if (TextSource != null)
        {
            TextSource.text = Localise(ReferenceName, LocalizationManager.Language);
        }
        else
        {
            Debug.LogError("Text source not set. For: '" + caller.name + "'.");
        }
    }

    public static string Localise(string refname, string lang)
    {
        string line = LocalizationFileManager.GetTranslationLineFromFile(lang, refname);
        string result = line.Substring(line.IndexOf("{") + "{".Length, line.LastIndexOf("}") - (line.IndexOf("{") + "{".Length));
        return result;
    }
}