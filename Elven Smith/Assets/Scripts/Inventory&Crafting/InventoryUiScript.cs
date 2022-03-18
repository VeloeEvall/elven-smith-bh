using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUiScript : MonoBehaviour
{
    private void Start()
    {
        InventorySystem.current.onInventoryChangedEvent += OnUpdateInventory;
    }

    private void OnUpdateInventory()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }

        DrawInventory();
    }

    public void DrawInventory()
    {
        foreach(InventoryItem item in InventoryItem.current.inventory)
        {
            AddInventorySlot(item);
        }
    }

    public void AddInventorySlot(InventoryItem item)
    {
        GameObject obj = Instantiate(m_slotPrefab);
        obj.transform.SetParent(transform, false);

        SlotScript slot = obj.GetComponent<SlotScript>();
        slot.Set(item);
    }
}
