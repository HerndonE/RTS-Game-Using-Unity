using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    private Rigidbody rb;

    //private Vector3 direction;
    //public Transform target; //public Transform target
    private float speed = 2.0f;

    public int health = 100;

    private float FreezY = 10;

    //Move along the waypoints
    private Waypoints[] navPoints;
    private Transform target;
    private Vector3 direction;
    public float amplify = 1;//speed
    private int index = 0;
    private bool move = true;


    /*
    void Start()
    {

    }
    */
    public void StartEnemy(Waypoints[] navigationPath)
    {
        navPoints = navigationPath;

        //Place our enemy at the start point
        transform.position = navPoints[index].transform.position;
        NextWaypoint();

        //Move towards the next waypoint
        //Retarget to the following waypoint when we reach our current waypoint
        //Repeat through all of the waypoints until you reach the end
    }


    //Need to move along multiple waypoints

    // Update is called once per frame
    void Update()
    {
        /*
        transform.position = new Vector3(transform.position.x, FreezY, transform.position.z); //Freezes 

        float distance = Vector3.Distance(transform.position, target.position);

        if(distance > 0.5f)
        {
            Vector3 direction = target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }

        //If Collide with A target, shoot at it, and freeze position till target is null
        */
        if (move)
        {
            transform.Translate(direction.normalized * Time.deltaTime * amplify);

            if ((transform.position - target.position).magnitude < .1f)
            {
                NextWaypoint();
            }
        }
    }

    private void NextWaypoint()
    {
        if (index < navPoints.Length - 1)
        {
            index += 1;
            target = navPoints[index].transform;
            direction = target.position - transform.position;
        }
        else
        {
            move = false;
        }
    }
}
