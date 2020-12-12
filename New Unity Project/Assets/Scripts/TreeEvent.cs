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

    public int MinimumIntensity;
    public int MaximumIntensity;

    public GameObject[] OrbitingCrystals;
    public Light ALight1;
    public Light ALight2;
    public Light ALight3;
    public Light ALight4;
    public Light ALight5;
    public Light PLight1;
    public Light PLight2;
    public Light PLight3;

    public bool ShouldIlluminate;

    public void Start()
    {
       OrbitingCrystals = GameObject.FindGameObjectsWithTag("Orbiting Crystals");

    }

    private void Update()
    {
        if(ShouldIlluminate && ALight1.intensity < 50)
        {
            ALight1.intensity += .25f;
        }
        if (ShouldIlluminate && ALight2.intensity < 50)
        {
            ALight2.intensity += .25f;
        }
        if (ShouldIlluminate && ALight3.intensity < 50)
        {
            ALight3.intensity += .25f;
        }
        if (ShouldIlluminate && ALight4.intensity < 50)
        {
            ALight4.intensity += .25f;
        }
        if (ShouldIlluminate && ALight5.intensity < 50)
        {
            ALight5.intensity += .25f;
        }
        if (ShouldIlluminate && PLight1.intensity < 75)
        {
            PLight1.intensity += .25f;
        }
        if (ShouldIlluminate && PLight2.intensity < 75)
        {
            PLight2.intensity += .25f;
        }
        if (ShouldIlluminate && PLight3.intensity < 75)
        {
            PLight3.intensity += .25f;
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(TreeEventFunction());
        }
    }

    private IEnumerator TreeEventFunction()
    {
        ShouldIlluminate = true;
        OC1.GetComponent<RotateNOrbit>().enabled = false;
        OC2.GetComponent<RotateNOrbit>().enabled = false;
        OC3.GetComponent<RotateNOrbit>().enabled = false;
        OC4.GetComponent<RotateNOrbit>().enabled = false;


        //PLight1.intensity = 75;
        //PLight2.intensity = 75;
        //PLight3.intensity = 75;
        //ALight1.intensity = MaximumIntensity;
        //ALight2.intensity = MaximumIntensity;
        //ALight3.intensity = MaximumIntensity;
        //ALight4.intensity = MaximumIntensity;
        //ALight5.intensity = MaximumIntensity;

        yield return new WaitForSeconds(2);


        PLight1.gameObject.SetActive(false);
        PLight2.gameObject.SetActive(false);
        PLight3.gameObject.SetActive(false);
        ALight1.gameObject.SetActive(false);
        ALight2.gameObject.SetActive(false);
        ALight3.gameObject.SetActive(false);
        ALight4.gameObject.SetActive(false);
        ALight5.gameObject.SetActive(false);


        //OC1.GetComponentInChildren<Rigidbody>().useGravity = true;
        //OC2.GetComponentInChildren<Rigidbody>().useGravity = true;
        //OC3.GetComponentInChildren<Rigidbody>().useGravity = true;
        //OC4.GetComponentInChildren<Rigidbody>().useGravity = true;

       foreach(GameObject crystal in OrbitingCrystals)
        {
            crystal.GetComponent<Rigidbody>().useGravity = true;
        }
   

        yield return new WaitForSeconds(4);

        //OC1.GetComponentInChildren<Rigidbody>().useGravity = false;
        //OC2.GetComponentInChildren<Rigidbody>().useGravity = false;
        //OC3.GetComponentInChildren<Rigidbody>().useGravity = false;
        //OC4.GetComponentInChildren<Rigidbody>().useGravity = false;

        foreach (GameObject crystal in OrbitingCrystals)
        {
            crystal.GetComponent<Rigidbody>().useGravity = false;
        }
    }

}
