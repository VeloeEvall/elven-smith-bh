using TMPro;
using UnityEngine;
using UnityEngine.UI;

// ##########
// Localization support for Elven Smith
// ##########

public class Localization : MonoBehaviour
{
    public bool Locked = false;

    [Header("Language:")]
    [SerializeField] [TextArea] private string Language = LocalizationManager.Language;

    [Space]
    [Header("Text sources:")]
    [SerializeField] private TMP_Text TMPTextSource = null;

    [SerializeField] private Text TextSource = null;
    [HideInInspector] public string ReferenceName = null;

    private void Awake()
    {
        if(!Locked)
        {
            LocalizationManager.ApplyLocalisation(gameObject, TMPTextSource, TextSource, ReferenceName);
        }
    }

    private void Reset()
    {
        if (TMPTextSource == null)
        {
            TMPTextSource = gameObject.GetComponentInChildren<TMP_Text>();
        }
        if (TextSource == null)
        {
            TextSource = gameObject.GetComponentInChildren<Text>();
        }
    }

    private void OnValidate()
    {
        if(!Locked)
        {
            if (LocalizationManager.Language == null)
            {
                LocalizationManager.Language = "pl";
                Language = "pl";
            }
            else if (LocalizationManager.Language != Language)
            {
                LocalizationManager.Language = Language;
            }
            LocalizationManager.ApplyLocalisation(gameObject, TMPTextSource, TextSource, ReferenceName);
        }
    }

    public void ReLocalize()
    {
        if(!Locked)
        {
            LocalizationManager.ApplyLocalisation(gameObject, TMPTextSource, TextSource, ReferenceName);
        }
    }
}