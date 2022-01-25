using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadingScreenPlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject RawImageObject;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject SavingSystemObject;

    private string _sceneName = "MainMenuScene";
    private AsyncOperation _sceneLoaderOperation;

    private SaveSys SavingSystem;
    private void Awake()
    {
        SavingSystem = SavingSystemObject.GetComponent<SaveSys>();

        //SavingSystem.LoadGame();
    }


    private void Start()
    {
        videoPlayer.Prepare();
        videoPlayer.loopPointReached += VideoPlayer_loopPointReached;
    }

    private void Update()
    {
        if (videoPlayer.isPrepared && !videoPlayer.isPlaying)
        {
            RawImageObject.SetActive(true);
            videoPlayer.Play();
            StartCoroutine(LoadSceneAsyncProcess(sceneName: _sceneName));
        }
    }

    private void VideoPlayer_loopPointReached(VideoPlayer source)
    {
        videoPlayer.Stop();
        _sceneLoaderOperation.allowSceneActivation = true;
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(_sceneName));
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
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
    }
}
