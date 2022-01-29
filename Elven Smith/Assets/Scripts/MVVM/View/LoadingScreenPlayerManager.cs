using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadingScreenPlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject RawImageObject;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject SavingSystemObject;

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
        SceneLoader.StartSceneLoading("MainMenuScene");
    }

    private void Update()
    {
        if (videoPlayer.isPrepared && !videoPlayer.isPlaying)
        {
            RawImageObject.SetActive(true);
            videoPlayer.Play();
        }
    }

    private void VideoPlayer_loopPointReached(VideoPlayer source)
    {
        videoPlayer.Stop();
        SceneLoader.ShowSceneWhenReady();
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(_sceneName));
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
