using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPostition : MonoBehaviour
{
    //Function to get mouse position

    public static Vector3 GetMousePosition()
    {
        Vector3 vec = GetMouseWorldPositionZ(Input.mousePosition, Camera.main);
        vec.z = 0f;

        return vec;
    }

    //Function to get mouse world position

    public  static Vector3 GetMouseWorldPositionZ()
    {
        return GetMouseWorldPositionZ(Input.mousePosition, Camera.main);
    }
    public  static Vector3 GetMouseWorldPositionZ(Camera worldCamera)
    {
        return GetMouseWorldPositionZ(Input.mousePosition, worldCamera);
    }

    public static Vector3 GetMouseWorldPositionZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
