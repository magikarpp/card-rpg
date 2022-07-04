using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    public enum ItemType
    {
        Card,
        Equipment,
        Potion,
        Scroll
    }

    public Sprite itemIcon;

    public Sprite itemImage;

    public Sprite itemBackgroundImage;

    public ItemType itemType;

    public string itemName;

    public string description;

    public int value;

    public bool isSellable;

    public float weight;

    public abstract void Use();

    public void Sell()
    {
    }

    public void Buy()
    {
    }
}
