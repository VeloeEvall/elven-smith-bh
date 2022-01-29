using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float speed;

    private float horizontal;
    private float vertical;
   
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
   
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        player.transform.position += new Vector3(horizontal, vertical);
    }
}
