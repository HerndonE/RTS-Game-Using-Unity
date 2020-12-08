﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceCollection : MonoBehaviour
{

    public float resourceGatheringTime = 5.0f;
    private bool gatheringInProduction = false;

    public Transform target;
    public Transform mineral;
    public Transform extractor;
    private float speed = 10;


    private bool toMin = false;
    private bool toBuild = false;

    private bool gamePaused = false;
    private Transform myTransform;


    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.GetComponent<NomadClick>().enabled == false) {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            resourceGatheringTime -= Time.deltaTime;
            Debug.Log("Time Left:" + Mathf.Round(resourceGatheringTime));
            if (resourceGatheringTime <= 0)
            {
                Debug.Log("Resource gathered");
               
                //this.GetComponent<NomadClick>().enabled = true;
                gatheringInProduction = false;
                transform.gameObject.SetActive(false);
                instantiateCollector();
               
            }


        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "mineral")
        {
            Debug.Log("I am at minerals");
            Destroy(col.collider.gameObject);
            gatheringInProduction = true;
            if (gatheringInProduction)
            {
                this.GetComponent<NomadClick>().enabled = false;
                toBuild = true;


            }
        }
    }

    void instantiateCollector()
    {
     
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (toBuild == true)
        {
            Instantiate(extractor, myTransform.position, Quaternion.identity);
            toBuild = false;
        }
      
    }

   

}
