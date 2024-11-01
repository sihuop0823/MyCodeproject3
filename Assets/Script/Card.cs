using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardGrade {Legend, Epic, SuperRare, Rare, common}

public class Card : MonoBehaviour
{
    public string cardName;
    public Sprite cardImage;
    public CardGrade cardGrade;

    public Card(Card card)
    {
        this.cardName = card.cardName;
        this.cardImage = card.cardImage;
        this.cardGrade = card.cardGrade;
    }
}
