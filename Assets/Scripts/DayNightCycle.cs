using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DayNightCycle : MonoBehaviour
{
    public float rotationSpeed = 10f;
    //public int timeOfDay = 12;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
