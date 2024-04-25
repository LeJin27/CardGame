using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField] SnapController snapController;
    [SerializeField] Draggable spawnDraggable;


    private void Update() {

        
    }

    private void Start() {
        ///SpawnCard();

    }


    public void SpawnCard() {
        Draggable spawnCard = Instantiate(spawnDraggable);
        spawnCard.transform.position = new Vector3(0, 0 ,0);

        snapController.addDraggable(spawnCard);

    }


    //retrieves Card object
    public Card GetCardAtIndex(int snapIndex) {
        SnapPoint snapPoint = snapController.getSnapPoint(snapIndex);
        Draggable draggable = snapPoint.getDraggable();

        Card currentCard = draggable.GetComponentInChildren<Card>();
        return currentCard;
    }
}
