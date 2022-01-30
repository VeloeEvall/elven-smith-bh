using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerAim : MonoBehaviour
{
    [SerializeField]
    private GameObject projectail;

    [SerializeField]
    private Transform aimTransform;

    [SerializeField]
    private Transform aimWeaponEndPoint;

    private void Update()
    {
        Aiming();
        //Shooting();
    }

    private void Aiming()
    {
        //Get mouse position
        Vector3 mousePosition = PointPostition.GetMousePosition();

        //Aim into direction normalized
        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        //Transform angle into Radian
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        //Rotate
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void Shooting()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate<GameObject>(projectail);
        }
    }
}
