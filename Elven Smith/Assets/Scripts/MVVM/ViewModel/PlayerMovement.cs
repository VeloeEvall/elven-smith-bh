using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    [SerializeField]
    private GameObject player;

    [SerializeField, Range(1, 3)]
    private float speed = 3.0f;

    void Update()
    {
        //player move 
        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        player.transform.Translate(horizontal, 0, vertical);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Collision
        player.transform.position = player.transform.position;
    }
}
