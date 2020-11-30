/*
 * Name: Ethan Herndon
 * Date: 11/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supplyManager : MonoBehaviour
{

    public int numOfSupplyBuildings;
    public static int supplyCountManager;
    public GameObject mainCamera;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("supply").Length >= numOfSupplyBuildings)
        {
            mainCamera.GetComponent<buildSupply>().enabled = false;
        }
        else
            mainCamera.GetComponent<buildSupply>().enabled = true;

        supplyCountManager = supplyModel.supplyCount;
        Debug.Log("Current Supply" + supplyCountManager);
    }
}
