/*
 * Name: Ethan Herndon
 * Date: 12/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supplyAwareness : MonoBehaviour
{

    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (GameObject.FindGameObjectWithTag("scavenger") != null)
        {
            //it exists
            mainCamera.GetComponent<buildSupply>().enabled = false;
        }
        else
        {
            mainCamera.GetComponent<buildSupply>().enabled = true;
        }

    }
}
