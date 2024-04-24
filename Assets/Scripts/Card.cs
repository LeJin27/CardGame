using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Card : MonoBehaviour
{
    
    public new string name;
    public int damage;
    public int health;
    public string description;
    public Sprite artwork;



    [SerializeField] CardSO cardSO;

    private void Start() {
        this.name = cardSO.name;
        this.damage = cardSO.damage;
        this.health = cardSO.health;
        this.description = cardSO.description;
        

    }



    public string getName() {
        return this.name;
    }

    public string getDescription() {
        return this.description;
    }
    public int getDamage() {
        return this.damage;
    }
    public int getHealth() {
        return this.health;
    }


    public void setHealth(int health) {
        this.health = health;
    }






    




}
