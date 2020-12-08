using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform target; //Testing 

    public Enemy currentTarget;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotates turret to look at current target
        if (target != null)
        {
            transform.LookAt(target);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 90f, 0); //Prevents any rotation on the x and z axis's
        }

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
        shot = Instantiate(bullet, transform.position, Quaternion.identity);

        Vector3 direction = target.position - transform.position;//transform.position is the current objects position
        direction.Normalize();

        shot.transform.position += direction * 5 * Time.deltaTime; //Directs the bullet towards the turrets current target

        Destroy(shot, 3f);
        
    }

    //Targeting Stuff
    void OnTriggerEnter(Collider collider)
    {
        /*
        Debug.Log("Something has entered");
        if (!target)
        {
            Debug.Log("I have collided with: " + target);
            if (collider.tag == "Enemy")
            {
                Debug.Log("My new target is : " + collider);
                target = collider.transform;
                // target = collider;
                //Enemy newEnemy = collider.GetComponent<Enemy>();
                //currentEnemies.Add(newEnemy);
            }
        }
        */

    }
}
