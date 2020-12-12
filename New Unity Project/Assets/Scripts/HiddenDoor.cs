using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoor : MonoBehaviour
{
    public GameObject door;
    public Collider range;
    public Vector3 pivot1;
    public Vector3 pivot2;
    public float speed;
    public bool inRange;


    public void Update()
    {
        if(inRange == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Opening Door");
            OpenDoor();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player is in Range");
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player is NOT in Range");
            inRange = false;
        }
    }


    public void OpenDoor()
    {
        transform.position = Vector3.MoveTowards(door.transform.position, pivot1, 4);
        transform.position = Vector3.MoveTowards(pivot1, pivot2, 10);
    }
}
