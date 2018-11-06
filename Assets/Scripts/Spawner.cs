﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabTospawn;
    public float adjustmentAngle = 0;

    public void spawn()
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

        Instantiate(prefabTospawn, transform.position, rotationInRadians);
    }

}