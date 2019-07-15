using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{

    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minmumAngle = 20f;


    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {

        DecreaseLightAngle();
        DecreaseLightIntensity();

    }

    //public void RestoreLightAngle(float restorAngle)
    //{
      //  myLight.spotAngle = restorAngle;
    //}

    //public void RestoreLightIntensity(float intensityAmont)
    //{
      //  myLight.intensity += intensityAmont; 
    //}


    private void DecreaseLightAngle()
    {

        if (myLight.spotAngle <= minmumAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }

    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }
}