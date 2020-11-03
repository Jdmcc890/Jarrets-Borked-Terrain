using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurScript : MonoBehaviour
{
  
    public AudioClip Anthem;
    public AudioSource audioSource;
 

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player Enters");
            GetComponent<AudioSource>().clip = Anthem;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player Exits");
            audioSource.Pause();
        }
    }
}
