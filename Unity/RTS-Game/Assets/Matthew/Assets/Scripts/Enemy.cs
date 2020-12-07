using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;

    //private Vector3 direction;
    public Transform target; //public Transform target
    private float speed = 2.0f;

    public int health = 100;

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
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }

        
    }
    
    
    /*void onTriggerEnter(Collider other)
    {
        Debug.Log("Enemy colliding with: " + other);
        if(other.gameObject.tag == "Bullet")
        {
            health -= 50;
            Destroy(other.gameObject);
            Debug.Log("Heath: " + health);
        }
    }*/
    

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Wow Ethan");
        Debug.Log("Enemy colliding with: " + col);
        if (col.gameObject.tag == "Bullet")
        {
            health -= 10;
            Destroy(col.gameObject);
            Debug.Log("Heath: " + health);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
