using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDash : MonoBehaviour
{
    [SerializeField]
    private bool playerInTrigger = false;
    [SerializeField]
    private Collider2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInTrigger = true;
        player = collision;
        
    }

    private void Update()
    {
        if(playerInTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<PlayerDash>().enabled = true;
            Destroy(this.gameObject);
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInTrigger = false;
    }
}
