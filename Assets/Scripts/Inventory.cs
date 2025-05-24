using UnityEngine;

public class Inventory : MonoBehaviour
{
    private InventoryItem[] items;

    public Inventory(int capacity)
    {
        items = new InventoryItem[capacity];
    }

    public void AddItem(InventoryItem item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].name == item.name && items[i].itemRarity == item.itemRarity && items[i].itemType == item.itemType)
            {
                if (item.isStackable)
                {
                    if (items[i].itemAmount < items[i].itemCount)
                        items[i].itemAmount++;
                    return;
                }
            }
            else if (items[i] == null)
            {
                items[i] = item;
                return;
            }
        }
        Debug.Log("Inventory is full");
    }

    public void RemoveItem(InventoryItem item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                if (item.isStackable)
                {
                    if (items[i].itemAmount > 1)
                    {
                        items[i].itemAmount--;
                    }
                    else
                    {
                        items[i] = null;
                    }
                }
                else
                {
                    items[i] = null;
                }
                return;
            }
        }
        Debug.Log("Item not found in inventory");
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
