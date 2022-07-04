using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card", fileName = "New Card")]
public class Card : Item
{
    public int manaCost;

    public int staminaCost;

    public int cooldown;

    public override void Use()
    {
    }
}
