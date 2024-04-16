using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
    void Awake() 
    {
        cardList.Add(new Card(0, "None1", 0, 0, "No description1"));
        cardList.Add(new Card(1, "None2", 0, 0, "No description2"));
        cardList.Add(new Card(2, "None3", 0, 0, "No description3"));
        cardList.Add(new Card(3, "None4", 0, 0, "No description4"));
    }


}
