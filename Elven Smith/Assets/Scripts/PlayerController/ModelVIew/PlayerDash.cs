using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    [SerializeField]
    private Transform destination;
    [SerializeField]
    private float dashSpeed;
    [SerializeField]
    //private bool isCollected = false;


    public void SetDashActive()
    {
        //isCollected = true;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) /*&& isCollected == true*/)
        {
            DashIn();
        }
    }

    private void DashIn()
    {
        //Get destination
        float destX = destination.position.x;
        float destY = destination.position.y;

        //Disable HP script
        GetComponent<PlayerHealth>().enabled = false;
        //Move into destination
        transform.position = new Vector3(destX, destY);
        //Enable HP script
        GetComponent<PlayerHealth>().enabled = true;
    }
}
