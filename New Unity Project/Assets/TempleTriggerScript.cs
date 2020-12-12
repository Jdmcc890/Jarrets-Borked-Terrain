using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempleTriggerScript : MonoBehaviour
{
    private Collider range;
    private bool inRange;

    public void Update()
    {
        if (inRange == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Opening Door");
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player is in Range");
            inRange = true;
        }
    }
}

