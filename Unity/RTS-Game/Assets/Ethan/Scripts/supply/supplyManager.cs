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
   // public int mineralCountManager;
    public GameObject mainCamera;
    public GameObject[] Factories;
    //public buildUnits supplyCheck;
    public Text supplyText;
    public Text resourceText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (((pumpResources.resourceCount + buildSupply.minCost + buildUnits.unit1MinCost + buildUnits.unit2MinCost) <= 0) || GameObject.FindGameObjectsWithTag("supply").Length >= numOfSupplyBuildings)
        {
            mainCamera.GetComponent<buildSupply>().enabled = false;
        }
        else if((pumpResources.resourceCount >= 10))
        {
            mainCamera.GetComponent<buildSupply>().enabled = true;

        }
      

            supplyCountManager = supplyModel.supplyCount;
        //Debug.Log("Current Supply" + supplyCountManager);
        supplyText.text = "Current Supply: " + unitModel.unitSupplyCount + "/" + supplyCountManager.ToString();

        resourceText.text = pumpResources.resourceCount + buildSupply.minCost + buildUnits.unit1MinCost + buildUnits.unit2MinCost + " Minerals";
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
