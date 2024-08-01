using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWallClimb : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 2;
    int index = 0;
    public bool isLoop = true;
    public Behaviour disablePlayer;
    public Collider trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                disablePlayer.enabled = false;
                Vector3 destination = waypoints[index].transform.position;
                Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
                transform.position = newPos;

                float distance = Vector3.Distance(transform.position, destination);
                if (distance <= 0.05)
                {
                    if (index < waypoints.Count - 1)
                    {
                        index++;
                    }
                    else
                    {
                        if (isLoop)
                        {
                            index = 0;
                        }
                    }
                }
            }
        }

    }

        // Update is called once per frame
    void Update()
    {
       



    }
}
