using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Turret : MonoBehaviour
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
        //Debug.Log("Transform?: " + transform);
        //If target is ever itself, nullify the target value
        //if(target = gameObject.transform)
        //{
        //    Debug.Log("Unassigning itself");
        //    target = null;
        //}

        Debug.Log("Current Target: " + target);
        transform.LookAt(target);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); //Prevents any rotation on the x and z axis's

        /*
        //Assigning a target with a click
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; //This variable stores location for hit and information about object.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Cast ray from main camera to mouse position
            //Debug.Log("" + hit);

            if (Physics.Raycast(ray, out hit))
            {
                target = hit.collider.transform; //Set target to hit object
            }
        }
        */

        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            target = null;//Erases current target
        }
        */

            //Automate this(Only fire if a target exists)
        if (target != null) 
        {
             //timer being set
             if(counter < 90)//Fire Rate
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
         
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire Bullet //Need to fire the bullet in the direction of where the turret is facing
            GameObject shot; //= Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);

            Vector3 direction = target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();

            shot.transform.position += direction * 5 * Time.deltaTime; //Directs the bullet towards the turrets current target

            Destroy(shot, 3f);
            

        }
        */

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
        Debug.Log("Something has entered");
        if (!target)
        {
            Debug.Log("I have collided with: "+target);
            if (collider.tag == "Enemy")
            {
                Debug.Log("My new target is : " + collider);
                target = collider.transform;
                // target = collider;
                //Enemy newEnemy = collider.GetComponent<Enemy>();
                //currentEnemies.Add(newEnemy);
            }
        }

    }

    void OnTriggerExit(Collider collider)
    {
        //Debug.Log("I'm about to unassign: " + target);
        //Debug.Log("I'm pretty sure it's gonna be: " + collider);
        //Ignore bullets leaving its radius
        if(target = collider.transform){
            Debug.Log("Unassigned: " + target);
            target = null;
        }
    }

    /*
    void OnTriggerExit(Collider collider)
    {
        Enemy enemyLeaving = collider.GetComponent<Enemy>();

        currentEnemies.Remove(enemyLeaving); //clean up
        evaluateTarget(enemyLeaving);

    }

    private void evaluateTarget(Enemy enemy)
    {
        if (currentTarget == enemy)
        {
            currentTarget = null;
            //lineRenderer.enabled = false;
        }

        if (currentTarget == null)
        {
            currentTarget = currentEnemies[0];
            //lineRenderer.enabled = true;
        }
    }
    */
}
