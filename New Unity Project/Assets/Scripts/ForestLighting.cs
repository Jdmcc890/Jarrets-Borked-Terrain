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

    public void Start()
    {
        currentSkybox = RenderSettings.skybox;
        Debug.Log(currentSkybox);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " entered the collider");
        if(other.name == "Player" && currentSkybox == NormalSkybox)
        {
            Debug.Log("Loading Night Scene");
            RenderSettings.skybox = ForestSkybox;
            RenderSettings.fog = true;
            GameObject.Find("DayLighting").SetActive(false);
            GameObject.Find("NightLighting").SetActive(true);
        }

        if (other.tag == "Player" && currentSkybox == ForestSkybox)
        {
            Debug.Log("Loading Day Scene");
            RenderSettings.skybox = NormalSkybox;
            RenderSettings.fog = false;
            GameObject.Find("DayLighting").SetActive(true);
            GameObject.Find("NightLighting").SetActive(false);
        }
    }
}
