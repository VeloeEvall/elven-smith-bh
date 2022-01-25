using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "NewItem";
    public Sprite icon = null;
    public Vector3 position = new Vector3(0, 0, 0);
}

