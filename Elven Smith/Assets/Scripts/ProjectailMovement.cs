using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectailMovement : MonoBehaviour
{
    private Vector3 mousePosition;
    [SerializeField]
    private float projectailSpeed = 0.5f;
    private Vector3 destinationPosition;
    private Vector3 aimDirection;
    private void Start()
    {
        transform.position = EndOfWeaponPosition. ;
        CalculateDestination();
    }

    private void Update()
    {
        Shooting();
    }

    private void Shooting()
    {
        transform.position += new Vector3(destinationPosition.x * projectailSpeed * Time.deltaTime, destinationPosition.y * projectailSpeed * Time.deltaTime, 0);
    }
    private void CalculateDestination()
    {
        //Get mouse position
        mousePosition = PointPostition.GetMousePosition();
        aimDirection = (mousePosition - transform.position).normalized;
        destinationPosition = new Vector3(aimDirection.x, aimDirection.y, 0);
    }
}
