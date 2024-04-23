using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapPoint : MonoBehaviour
{
    public Draggable currentDraggable;

    private void Start() {
        currentDraggable = null;
    }

    private void Update() {
    }

    public bool containsDraggable() {
        if (currentDraggable == null) {
            return false;
        } else {
            return true;
        }
    }

    public void setDraggable(Draggable draggableObject) {
        currentDraggable = draggableObject;
    }

    public Draggable getDraggable() {
        return currentDraggable;
    }
}
