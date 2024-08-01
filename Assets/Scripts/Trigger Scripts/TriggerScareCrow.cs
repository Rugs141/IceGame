using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScareCrow : MonoBehaviour
{
    // Trigger for our main horror monster the scarecrow
    // What variables do we need?
    // the actualy game object will will set to active or instatiate
    // the different number of game object position it could spawn?
    // mayble multiple scarewcrow could spawn
    // how quicky will it spawn if the player gte out of the cabin
    // fail state if the player does die and get caught
    // This might have to go into scarecrow Ai but perhaps if you look at it look at the creature long enought its sapwns at another location

    public GameObject[] objects;
    public int objNum;
    public int objCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objNum = Random.Range(0, 3);
            objCount = 0;
            while (objCount < 3)
            {
                objects[objCount].SetActive(false);
                objCount += 1;
            }
            objects[objNum].SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            Destroy(gameObject);
        }


    }
}
