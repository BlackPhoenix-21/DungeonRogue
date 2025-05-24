using UnityEngine;

[CreateAssetMenu(menuName = "MyObjects/InventoryItem", fileName = "InventoryItem")]
public class InventoryItem : ScriptableObject
{
    public enum ItemRarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable,
        Material,
        Miscellaneous
    }

    public string baseitemName;
    public string baseitemDescription;
    public Sprite baseitemIcon;
    public bool buyable;
    public int baseitemPrice;
    public bool isStackable;
    public int baseitemCount;
    public ItemRarity baseitemRarity;
    public ItemType baseitemType;

    [HideInInspector]
    public string itemName, itemDescription;
    [HideInInspector]
    public Sprite itemIcon;
    [HideInInspector]
    public int itemPrice, itemCount, itemAmount;
    [HideInInspector]
    public ItemRarity itemRarity;
    [HideInInspector]
    public ItemType itemType;

    public void Rest()
    {
        itemName = baseitemName;
        itemDescription = baseitemDescription;
        itemIcon = baseitemIcon;
        itemPrice = baseitemPrice;
        itemCount = baseitemCount;
        itemAmount = 1;
        itemRarity = baseitemRarity;
        itemType = baseitemType;
    }
}
