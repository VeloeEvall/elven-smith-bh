using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFunctions : MonoBehaviour
{

    [SerializeField] private GameObject SettingsMenuGameObject;

    public void ShowSettingsMenu()
    {
        if (SettingsMenuGameObject != null)
        {
            SettingsMenuGameObject.SetActive(true);
        }
    }

    public void HideSettingsMenu()
    {
        if (SettingsMenuGameObject != null)
        {
            SettingsMenuGameObject.SetActive(false);
        }
    }

    public void StartNewGame()
    {
        SceneLoader.StartSceneLoading("SystemTesting");
        SceneLoader.ShowSceneWhenReady();
    }
    public void LoadGame()
    {
        SceneLoader.StartSceneLoading("SystemTesting");
        SceneLoader.ShowSceneWhenReady();
    }

    public void QuitGame()
    {
        // DEV ONLY
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }

}
