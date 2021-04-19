using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    private const float pi = Mathf.PI;

    private const float coeff = 0.083333f;

    public float angularMomentum; //vector

    public float mass;

    public float length;


    public float momentOfInertia; //vector

    public float angularVelocity;

    void Awake()
    {
        /*angularMomentum = 1.0f;
        mass = 1.0f;
        length = 1.0f;
        angularVelocity = 1.0f;
        angularAcceleration = 1.0f;
        momentOfInertia = 1.0f;*/
    }

    void getMomentOfInertia()
    {
        momentOfInertia = coeff * mass * Mathf.Pow(length, 2);
    }

    void getAngularMomentum()
    {
        angularMomentum = momentOfInertia * angularVelocity;
    }

    void getAngularVelocity()
    {
        angularVelocity = angularMomentum / momentOfInertia;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getMomentOfInertia();
        //getAngularMomentum();
        getAngularVelocity();
        float angVelConverted = angularVelocity * (180/pi); 
        transform.Rotate(Vector3.down * Time.deltaTime * angVelConverted);
    }



}
