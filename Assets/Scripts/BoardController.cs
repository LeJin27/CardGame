using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField] SnapController snapController;
    [SerializeField] Draggable spawnDraggable;
    [SerializeField] SnapPoint spawnSnapPoint;
    [SerializeField] GameObject snapPointParent;


    private void Update() {

        
    }

    private void Start() {


        

    }



    private void SpawnHandPoints(int pointAmount) {
        var screenBottomCenter = new Vector3(Screen.width/2, Screen.height/5, 0); 
        var inWorld = Camera.main.ScreenToWorldPoint(screenBottomCenter);
        inWorld.z = 0;
        for (int i = 0; i < pointAmount; i ++) {
            SnapPoint snapPoint  = Instantiate(spawnSnapPoint, snapPointParent.transform.parent);
            snapPoint.transform.position = inWorld;
            snapController.AddSnapPoint(snapPoint);

        }

    }



    public void SpawnCard() {
        Draggable spawnCard = Instantiate(spawnDraggable);
        spawnCard.transform.position = new Vector3(0, 0 ,0);

        snapController.AddDraggable(spawnCard);

    }


    //retrieves Card object
    public Card GetCardAtIndex(int snapIndex) {
        SnapPoint snapPoint = snapController.GetSnapPoint(snapIndex);
        Draggable draggable = snapPoint.getDraggable();

        Card currentCard = draggable.GetComponentInChildren<Card>();
        return currentCard;
    }
}
