using UnityEngine;

public class ToggleInventory : MonoBehaviour
{
    [SerializeField] GameObject inventoryGameObject;
    [SerializeField] KeyCode[] toggleInventoryKey;

    private void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            inventoryGameObject.SetActive(!inventoryGameObject.activeSelf);

        }


    }
}
