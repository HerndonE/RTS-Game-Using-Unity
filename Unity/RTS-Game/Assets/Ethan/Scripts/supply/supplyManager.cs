/*
 * Name: Ethan Herndon
 * Date: 11/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class supplyManager : MonoBehaviour
{

    public int numOfSupplyBuildings;
    public int supplyCountManager;
    public GameObject mainCamera;
    public GameObject[] Factories;
    //public buildUnits supplyCheck;
    public Text supplyText;

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
        {
            mainCamera.GetComponent<buildSupply>().enabled = true;
          
        }

        supplyCountManager = supplyModel.supplyCount;
        //Debug.Log("Current Supply" + supplyCountManager);
        supplyText.text = "Current Supply: " + unitModel.unitSupplyCount + "/" + supplyCountManager.ToString();
        //supplyCheck.unitySupplyCountTemp + "/" + supplyCountManager.ToString(); old Code

        Factories = GameObject.FindGameObjectsWithTag("building");
        if (unitModel.unitSupplyCount >= supplyCountManager)
        {
          
            for(int i = 0; i < Factories.Length; i++)
            {
                Factories[i].GetComponent<buildUnits>().enabled = false;
            }
            
            //Debug.Log("YOU MUST CONSTRUCT ADDITIONAL PYLONS!");

        }
     /*   else
        {
            for (int i = 0; i < Factories.Length; i++)
            {
                Factories[i].GetComponent<buildUnits>().enabled = true;
            }
            //Debug.Log("GO GO GO");
        }*/


    }
}
