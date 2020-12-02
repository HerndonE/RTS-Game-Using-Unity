using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody myRigidbody;
    public float speed = 5;
    public Transform target; //public Transform target

    //public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        Fire();
    }

    private void Fire()
    {
        
        //myRigidbody.velocity = Vector3.up * speed;
        //Debug.Log("Wwweeeeee");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject theTurret = GameObject.Find("Turret");
        Turret turretScript = theTurret.GetComponent<Turret>();

        float distance = Vector3.Distance(transform.position, turretScript.target.position);

        if (distance > 0.5f)
        {
            Vector3 direction = turretScript.target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hello!");
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("Hello!");
        }
        
        
    }
}
