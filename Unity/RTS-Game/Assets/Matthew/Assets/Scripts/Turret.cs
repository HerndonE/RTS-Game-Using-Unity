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
    public List<Enemy> currentEnemies;
    public Enemy currentTarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.LookAt(target);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); //Prevents any rotation on the x and z axis's

        //Smoothly transitioning to look at enemy

        //Rotating and Updating Rotation position
        //yRotation++;
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire Bullet //Need to fire the bullet in the direction of where the turret is facing
            //GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            //Destroy(shot, 3f);


        }

    }

    //Targeting Stuff
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.tag == "Enemy")
        {
            // target = collider;
            Enemy newEnemy = collider.GetComponent<Enemy>();
            currentEnemies.Add(newEnemy);
        }
        /*
        Enemy newEnemy = collider.GetComponent<Enemy>();
        currentEnemies.Add(newEnemy);

        evaluateTarget(newEnemy);
        */
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
