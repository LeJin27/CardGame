using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;
    public int damage;
    public string cardDescription;

    public Card() {

    }

    public Card(int id, string cardName, int cost, int damage, string cardDescription) {
        this.id = id;
        this.cardName = cardName;
        this.cost = cost;
        this.damage = damage;
        this.cardDescription = cardDescription;
    }
}
