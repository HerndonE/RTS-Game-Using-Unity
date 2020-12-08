using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    private Rigidbody rb;

    //private Vector3 direction;
    public Transform target; //public Transform target
   // public Transform shottingOffset;

    //public GameObject bullet; //bullet needed
    public float speed = 4.0f;

    public int health = 100;

    private float FreezY = 10;

    private bool Collided = false;
    private int counter = 0;

    //private Vector3 heading = target.position - transform.position;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            transform.LookAt(target);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - 90, 0);
        }
        


        transform.position = new Vector3(transform.position.x, FreezY, transform.position.z);

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > 0.5f)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }


        /*
        if(Collided)
        {
            speed = 0f;
            //timer being set
            if (counter < 90)//Fire Rate
            {
                counter += 1;
            }
            else
            {
                //Fire Bullet, Reset Counter
                Fire();
                counter = 0;
            }
            
        }
        else
        {
            speed = 4.0f;
        }
        */

    }

    /*
    void OnTriggetEnter(Collider collider)
    {
        Debug.Log("I have collided");
        //It has reached the destination
        if (target = collider.transform)//if collider.tag == "Goal"
        {
            Destroy(gameObject);//Kill itself
        }
    }
    */
    /*
    private void Fire()
    {
        GameObject shot; //= Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);

        Vector3 direction = target.position - transform.position;//transform.position is the current objects position
        direction.Normalize();

        shot.transform.position += direction * 5 * Time.deltaTime; //Directs the bullet towards the turrets current target

        Destroy(shot, 3f);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("I have collided");
        if(col.gameObject.tag == "EnemyTurret")
        {
            Collided = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        Debug.Log("I am leaving");
        if (col.gameObject.tag == "EnemyTurret")
        {
            Collided = false;
        }
    }
    */

}
