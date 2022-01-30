using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuFunctions : MonoBehaviour
{

    public void BackToMainMenu()
    {
        SceneLoader.StartSceneLoading("MainMenuScene");
        SceneLoader.ShowSceneWhenReady();
    }

}
