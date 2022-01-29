using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void InitializeType()
    {
        instance = new GameObject($"#{nameof(SceneLoader)}").AddComponent<SceneLoader>();
        DontDestroyOnLoad(instance);
    }
    void Awake()
    {
        instance = this;
    }

    private string _sceneName;
    private AsyncOperation _sceneLoaderOperation;

    private bool _SceneLoadingDone = false;

    public static void StartSceneLoading(string SceneToLoad)
    {
        if(CheckIfSceneExists(SceneToLoad))
        {
            instance._sceneName = SceneToLoad;
            instance.StartCoroutine(instance.LoadSceneAsyncProcess(sceneName: instance._sceneName));
        }
    }

    public static bool SceneLoadingDone()
    {
        return instance._SceneLoadingDone;
    }

    public static void ShowSceneWhenReady()
    {
        instance._sceneLoaderOperation.allowSceneActivation = true;
    }

    private IEnumerator LoadSceneAsyncProcess(string sceneName)
    {
        _sceneLoaderOperation = SceneManager.LoadSceneAsync(sceneName);
        _sceneLoaderOperation.allowSceneActivation = false;
        while (!_sceneLoaderOperation.isDone)
        {
            //Debug.Log($"[scene]:{sceneName} [load progress]: {_sceneLoaderOperation.progress}");
            
            yield return null;
        }
        instance._SceneLoadingDone = true;
    }

    private static bool CheckIfSceneExists(string sName)
    {
        bool _exists = false;
        for (var i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            if(SceneUtility.GetScenePathByBuildIndex(i).IndexOf(sName) > -1) _exists = true;
            //Debug.Log("[SceneLoader] Index: " + i + ". Path: " + x + ".");
        }
        return _exists;
    }

}
