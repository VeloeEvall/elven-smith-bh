using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Collider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        SceneManager.LoadScene(3);
    }
}
