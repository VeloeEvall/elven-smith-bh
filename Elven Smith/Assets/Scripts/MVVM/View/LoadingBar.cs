using UnityEngine;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] private RectTransform rectComponent;
    [SerializeField] [Range(-1000, 1000)] private float rotateSpeed = 200f;
#pragma warning disable CS0414 // Remove unread private members
    [SerializeField] private RotationDirection Direction = RotationDirection.Right;
#pragma warning restore CS0414 // Remove unread private members
    public enum RotationDirection
    {
        Left,
        Right
    }

    private void Update()
    {

        rectComponent.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
    private void Reset()
    {
        rectComponent = gameObject.GetComponentInChildren<RectTransform>();
    }

    private void OnValidate()
    {
        if (rotateSpeed < 0)
        {
            Direction = RotationDirection.Right;
        }
        else
        {
            Direction = RotationDirection.Left;
        }
    }
}