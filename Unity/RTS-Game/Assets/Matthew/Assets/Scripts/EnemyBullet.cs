using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
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
        GameObject theEnemyTurret = GameObject.Find("EnemyTurret");
        EnemyTurret enemyTurretScript = theEnemyTurret.GetComponent<EnemyTurret>();

        if (!enemyTurretScript.target)
        {
            Destroy(gameObject);
        }


        float distance = Vector3.Distance(transform.position, enemyTurretScript.target.position);

        if (distance > 0.5f)
        {
            Vector3 direction = enemyTurretScript.target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hello!");
        if (other.tag == "Ally")
        {
            Destroy(other.gameObject);
            //Destroy(gameObject);
            Debug.Log("Hello!");
        }


    }
}
