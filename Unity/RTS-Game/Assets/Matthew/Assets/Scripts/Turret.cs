using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float yRotation = 0;
    public GameObject bullet;
    public Transform shottingOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotating and Updating Rotation position
        yRotation++;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire Bullet
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);

            Destroy(shot, 3f);

            //Need to fire the bullet in the direction of where the turret is facing
        }

    }
}
