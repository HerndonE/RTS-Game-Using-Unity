using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform target; //Testing 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        GameObject theTurret = GameObject.Find("Turret");
        Turret turretScript = theTurret.GetComponent<Turret>();

        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject shot; //= Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            shot = Instantiate(bullet, transform.position, Quaternion.identity);

            Vector3 direction = turretScript.target.position - transform.position;//transform.position is the current objects position
            direction.Normalize();

            //shot.transform.position += direction * 5 * Time.deltaTime; //Directs the bullet towards the turrets current target

        }
        */
    }
}
