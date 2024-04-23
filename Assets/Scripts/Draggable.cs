using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    //instatntiated by snapcontroller
    public delegate bool DragEndedDelegate(Draggable draggableObject);
    public DragEndedDelegate dragEndedCallback;
    private SnapPoint currentSnapPoint = null;


    private bool isDragged = false;
    private bool isSnapped = false;
    public Vector3 mouseDragStartPosition;
    public Vector3 spriteDragStartPosition;

    public void setSnapPoint(SnapPoint snapObject) {
        currentSnapPoint = snapObject;
    }

    private void Start() {
    }


    
    private void OnMouseDown() {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }
    private void OnMouseDrag() {
        if (isDragged) {
            //this is setting the start position to the starting positon + (difference between mouse positons)
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }
    private void OnMouseUp() {
        isDragged = false;
        //call our dummy function

        isSnapped = dragEndedCallback(this);
    }

    private void Update() {
        //animation for snapping
        if (isSnapped && isDragged == false) {
            transform.localPosition = Vector2.Lerp(transform.localPosition, currentSnapPoint.transform.localPosition, Time.deltaTime * 10);
        }
    }
}
