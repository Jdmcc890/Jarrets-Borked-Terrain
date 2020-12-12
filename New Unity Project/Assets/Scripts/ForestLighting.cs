using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestLighting : MonoBehaviour
{
    public BoxCollider ForestTrigger;
    public BoxCollider ForestTrigger1;
    public Material ForestSkybox;
    public Material currentSkybox;
    public Material NormalSkybox;
    public Light DayLight;
    public Light NightLight;

    public void FixedUpdate()
    {
        currentSkybox = RenderSettings.skybox;

    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " entered the collider");
        if(other.name == "Player" && currentSkybox == NormalSkybox)
        {
            Debug.Log("Loading Night Scene");
            RenderSettings.skybox = ForestSkybox;
            RenderSettings.fog = true;
            DayLight.gameObject.SetActive(false);
            NightLight.gameObject.SetActive(true);
        }

        if (other.tag == "Player" && currentSkybox == ForestSkybox)
        {
            Debug.Log("Loading Day Scene");
            RenderSettings.skybox = NormalSkybox;
            RenderSettings.fog = false;
            DayLight.gameObject.SetActive(true);
            NightLight.gameObject.SetActive(false);
        }
    }
}
