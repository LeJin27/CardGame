using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{

    public List<Transform> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 0.5f;



    void Start() {
        foreach (Draggable draggable in draggableObjects) {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }

    private bool OnDragEnded(Draggable draggable) {
        //every draggable object will have properties distance and snap point
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        //for every snap point in list
        foreach(Transform snapPoint in snapPoints) {
            //get distance between all snap points
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);

            //always have closesnt distance and closesnt snapoint have a value
            if (closestSnapPoint == null || currentDistance < closestDistance) {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        if (closestSnapPoint != null && closestDistance <= snapRange) {
            draggable.currentSnapPoint = closestSnapPoint;
            //draggable.transform.localPosition = closestSnapPoint.localPosition;
            return true;
        } else {
            draggable.currentSnapPoint = null;
            return false;

        }
    }



    //[SerializeField] Draggable draggableObject;
    //[SerializeField] GameObject snapObject;

    //private void Snap() {
    //    float width = snapObject.GetComponent<SpriteRenderer>().bounds.size.x;
    //    float currentDistance = Vector2.Distance(draggableObject.transform.localPosition, snapObject.transform.localPosition);

    //    if (currentDistance < width) {
    //        draggableObject.transform.localPosition = Vector2.Lerp(draggableObject.transform.position, snapObject.transform.position, Time.deltaTime * 10);
    //    }

    //    Debug.Log(width);


    //}






}
