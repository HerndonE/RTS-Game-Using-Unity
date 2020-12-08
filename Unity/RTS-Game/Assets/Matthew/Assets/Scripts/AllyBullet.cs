using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBullet : MonoBehaviour
{
    private Rigidbody myRigidbody;
    public float speed = 25;
    public Transform target; //public Transform target
    public AudioSource pewpew;

    //public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        Fire();
    }

    private void Fire()
    {
        pewpew.Play();
        //myRigidbody.velocity = Vector3.up * speed;
        //Debug.Log("Wwweeeeee");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject theAllyCar = GameObject.Find("Ally");
        Ally AllyCarScript = theAllyCar.GetComponent<Ally>();

        if (!AllyCarScript.target)
        {
            Destroy(gameObject);
        }

        float distance = Vector3.Distance(transform.position, AllyCarScript.target.position);

        if (distance > 0.5f)
        {
            Vector3 direction = AllyCarScript.target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "EnemyTurret")
        {
            Destroy(gameObject);
        }
    }
}
