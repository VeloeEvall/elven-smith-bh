using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickupItem();
    }
    public void PickupItem()
    {
        InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
    }
}
