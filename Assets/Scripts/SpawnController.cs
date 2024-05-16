using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] GameObject spawnPointParent;
    public List<GameObject> spawnPointList;
    [SerializeField] List<GameObject> cards;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0 ; i < cards.Count; i++) {
            spawnAtIndexPosition(i, cards[i]);
        }





        
    }

    void spawnAtIndexPosition(int indexPosition, GameObject spawnCard) {
        Vector3 cardPosition = spawnPointList[indexPosition].transform.position;
        GameObject cardToPlace  = Instantiate(spawnCard);
        cardToPlace.transform.position = cardPosition;



    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
