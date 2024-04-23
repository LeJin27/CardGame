using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] CardSO cardSO;



    public string getCardName() {
        return cardSO.name;
    }



    




}
