using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    //instatntiated by snapcontroller
    public delegate bool DragEndedDelegate(Draggable draggableObject);
    public DragEndedDelegate dragEndedCallback;
    private SnapPoint currentSnapPoint = null;


    public bool isDragged = false;
    public bool isSnapped = false;
    public Vector3 mouseDragStartPosition;
    public Vector3 spriteDragStartPosition;
    private Vector3 originalScale;

    public void setSnapPoint(SnapPoint snapObject) {
        currentSnapPoint = snapObject;
    }

    private void Start() {
    	originalScale = transform.localScale;
    }


	void OnMouseOver()
	{
    	Vector3 scaleChange = new Vector3(0.3f, 0.3f, 0.3f);
    	transform.localScale += scaleChange * Time.deltaTime;
    	Mathf.Clamp(transform.localScale.x, 1, 1.4f);
    	Mathf.Clamp(transform.localScale.y, 1, 1.4f);
    	Mathf.Clamp(transform.localScale.z, 1, 1.4f);
    	//If your mouse hovers over the GameObject with the script attached, output this message
    	Debug.Log("Mouse is over GameObject.");
	}

	private void OnMouseExit() {
    	transform.localScale = originalScale;
	}



    
    private void OnMouseDown() {
        isDragged = true;

        if (currentSnapPoint != null) {
            currentSnapPoint.setDraggable(null);
        }

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
