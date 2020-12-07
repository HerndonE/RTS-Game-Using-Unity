using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    //float yRotation = 0;
    public GameObject bullet;
    public Transform target; //Testing 
    public Transform shottingOffset;

    //Targeting Stuff
    //public List<Enemy> currentEnemies;
    //public Enemy currentTarget;
    private int counter = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Current Target: " + target);
        transform.LookAt(target);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); //Prevents any rotation on the x and z axis's

        //Automate this(Only fire if a target exists)
        if (target != null)
        {
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

    }

    private void Fire()
    {
        //Fire Bullet //Need to fire the bullet in the direction of where the turret is facing
        GameObject shot; //= Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);

        Vector3 direction = target.position - transform.position;//transform.position is the current objects position
        direction.Normalize();

        shot.transform.position += direction * 5 * Time.deltaTime; //Directs the bullet towards the turrets current target

        Destroy(shot, 3f);
    }

    //Targeting Stuff
    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("Something has entered");
        if (!target)
        {
            Debug.Log("I have collided with: " + target);
            if (collider.tag == "Ally")
            {
                Debug.Log("My new target is : " + collider);
                target = collider.transform;
            }
        }

    }

    void OnTriggerExit(Collider collider)
    {
        //Ignore bullets leaving its radius
        if (target = collider.transform)
        {
            Debug.Log("Unassigned: " + target);
            target = null;
        }
    }

}
