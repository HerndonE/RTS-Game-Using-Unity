using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialVelocity : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float upSpeed = 0f;


    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody>().velocity = forwardSpeed * transform.right * -1;// + upSpeed * transform.up;
    }
}
