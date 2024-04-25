using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Card : MonoBehaviour
{
    
    public new string name;
    public int damage;
    public int health;
    public string description;
    public Sprite artwork;
    


    [SerializeField] TextMeshPro healthText;
    [SerializeField] TextMeshPro damageText;
    [SerializeField] TextMeshPro descriptionText;
    [SerializeField] TextMeshPro nameText;

    [SerializeField] CardSO cardSO;

    private void Start() {
        this.description = cardSO.description;
        setDamage(cardSO.damage);
        setHealth(cardSO.health);
        setName(cardSO.name);


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
        healthText.SetText(health.ToString());
    }
    public void setDamage(int damage) {
        this.damage = damage;
        damageText.SetText(damage.ToString());
    }
    public void setName(string name) {
        this.name = name;
        nameText.SetText(name);
    }






    




}
