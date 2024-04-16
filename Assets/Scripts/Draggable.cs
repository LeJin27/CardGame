using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    //instatntiated by snapcontroller
    public delegate bool DragEndedDelegate(Draggable draggableObject);
    public DragEndedDelegate dragEndedCallback;
    public Transform currentSnapPoint = null;


    private bool isDragged = false;
    private bool isSnapped = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;


    
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
        if (isSnapped && isDragged == false) {
            //transform.localPosition = currentSnapPoint.localPosition;
            transform.localPosition = Vector2.Lerp(transform.localPosition, currentSnapPoint.localPosition, Time.deltaTime * 10);
            Debug.Log("true");
        } else {
            Debug.Log("false");
        }
    }
}
