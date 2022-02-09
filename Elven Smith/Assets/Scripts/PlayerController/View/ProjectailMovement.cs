using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectailMovement : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 desination;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float timeSpan;
    private void Start()
    {
        //Get mouse position
        mousePos = PointPostition.GetMousePosition();
        //Aim into direction normalized
        desination = (mousePos - transform.position).normalized;
    }

    void Update()
    {
        //Move toward mouse point
        transform.position += new Vector3(desination.x * speed * Time.deltaTime, desination.y * speed * Time.deltaTime, 0);
        //Destroy after x sec
        Destroy(this.gameObject, timeSpan); 
    }
}
