using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{

    public List<Transform> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 0.5f;



    void Start() {
    }

    private void OnDragEnded(Draggable draggable) {
        float closestDistance = -1;
        Transform closestSnapPoint = null;
        foreach(Transform snapPoint in snapPoints) {
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);



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
