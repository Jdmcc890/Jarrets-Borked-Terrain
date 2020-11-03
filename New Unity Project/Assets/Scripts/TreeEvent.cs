using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeEvent : MonoBehaviour
{

    public GameObject OC1;
    public GameObject OC2;
    public GameObject OC3;
    public GameObject OC4;

    public Collider EventTrigger;

    public int MaximumIntensity;

    public GameObject[] OrbitingCrystals;


    public void Start()
    {
        OrbitingCrystals = GameObject.FindGameObjectsWithTag("Orbiting Crystals");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            TreeEventFunction();
        }
    }

    public void TreeEventFunction()
    {
        OC1.GetComponent<RotateNOrbit>().enabled = false;
        OC2.GetComponent<RotateNOrbit>().enabled = false;
        OC3.GetComponent<RotateNOrbit>().enabled = false;
        OC4.GetComponent<RotateNOrbit>().enabled = false;
    }

}
