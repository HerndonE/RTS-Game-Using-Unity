using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody myRigidbody;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        Fire();
    }

    private void Fire()
    {
        myRigidbody.velocity = Vector3.up * speed;
        //Debug.Log("Wwweeeeee");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
