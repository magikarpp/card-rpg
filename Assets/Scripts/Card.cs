using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public string cardName;
    [TextArea(1,3)]
    public string cardDescription;

    public Sprite cardSprite;
    public Sprite cardBgSprite;

    public int cardMana;
    public int cardStamina;
    public int cardCooldown;
}
