using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotater : MonoBehaviour
{
    public int rotateSpeed;
    Rigidbody physics;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.angularVelocity = Random.insideUnitSphere * rotateSpeed; 
    }
}

