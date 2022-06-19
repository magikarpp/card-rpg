using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public string name;
    [TextArea(1,3)]
    public string description;

    public Sprite sprite;
    public Sprite bgSprite;

    public int manaCost;
    public int staminaCost;
    public int cooldown;
}
