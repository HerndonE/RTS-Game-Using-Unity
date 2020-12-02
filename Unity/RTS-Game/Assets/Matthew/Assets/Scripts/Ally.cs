using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    private Rigidbody rb;

    //private Vector3 direction;
    public Transform target; //public Transform target
    private float speed = 2.0f;

    //private Vector3 heading = target.position - transform.position;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if(distance > 0.5f)
        {
            Vector3 direction = target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
