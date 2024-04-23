using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Snap controller. Manages snapping points and draggable objects
// Draggable objects can function without the snap controller 
// Snap controller is used to provide snapping feature to snap points


public class SnapController : MonoBehaviour
{

    public List<SnapPoint> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 0.5f;

    //intialize delegate function for all draggable points (could change )
    void Start() {
        foreach (Draggable draggable in draggableObjects) {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }






    public void addDraggable(Draggable draggableToAdd) {
        draggableObjects.Add(draggableToAdd);
    }



    public SnapPoint getSnapPoint(int index) {
        return snapPoints[index];
    }






    //Used on mosue up in draggable
    private bool OnDragEnded(Draggable draggable) {


        //every draggable object will have properties distance and snap point
        float closestDistance = -1;
        SnapPoint closestSnapPoint = null;

        //for every snap point in list
        foreach(SnapPoint snapPoint in snapPoints) {
                //get distance between all snap points
                float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.transform.localPosition);

                //always have closesnt distance and closesnt snapoint have a value
                if (closestSnapPoint == null || currentDistance < closestDistance) {
                    closestSnapPoint = snapPoint;
                    closestDistance = currentDistance;
                }



        }
        //edge case where they are on top of one noather 
        if (closestSnapPoint.getDraggable() != null) {
            return false;
        }


        if (closestSnapPoint != null && closestDistance <= snapRange) {

            draggable.setSnapPoint(closestSnapPoint);
            closestSnapPoint.setDraggable(draggable);

            //if true performs snap operation
            return true;
        } else {
            draggable.setSnapPoint(null);
            closestSnapPoint.setDraggable(null);
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
