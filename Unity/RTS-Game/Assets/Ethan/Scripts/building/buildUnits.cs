/*
 * Name: Ethan Herndon
 * Date: 11/16/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildUnits: MonoBehaviour
{

    public GameObject unit1;
    public GameObject unit2;
    public GameObject gameManager;
    public Transform spawnPointOne;
    public Transform spawnPointTwo;
    public float unit1ProductionTime = 5.0f;
    public float unit1ProductionReset = 5.0f;
    public float unit2ProductionTime = 10.0f;
    public float unit2ProductionReset = 10.0f;
    public static int unit1MinCost;
    public static int unit2MinCost;
    private bool unit1InProduction = false;
    private bool unit2InProduction = false;
    //public int unit1SupplyCount = 10;
    //public int unit2SupplyCount = 20;
    //public int unitSupplyLoss;
    //public int unitySupplyCountTemp = 0;
    //public supplyManager getCurrSupply;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            unit1InProduction = true;
            print("one was pressed");
        }
        if (unit1InProduction)
        {
            unit1ProductionTime -=  Time.deltaTime;
            Debug.Log("Time Left:" + Mathf.Round(unit1ProductionTime));
            if (unit1ProductionTime < 0)
            {
                //Transform spawnPoint = transform.Find("/spawnPoint").gameObject;
                spawnPointOne = this.transform.Find("spawnPointOne");
                Instantiate(unit1, spawnPointOne.position, spawnPointOne.rotation);
                unit1MinCost = unit1MinCost - 10;

               /* unitySupplyCountTemp += unit1SupplyCount;
                unitSupplyLoss = getCurrSupply.supplyCountManager;
                Debug.Log("subtracted: " + unitySupplyCountTemp + " from " + unitSupplyLoss);*/

                GameObject building = GameObject.FindWithTag("building");
                building.GetComponent<buildUnits>().enabled = false;

                unit1ProductionTime = unit1ProductionReset;
                unit1InProduction = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            unit2InProduction = true;
            print("two was pressed");
        }
        if (unit2InProduction)
        {
            unit2ProductionTime -= Time.deltaTime;
            Debug.Log("Time Left:" + Mathf.Round(unit2ProductionTime));
            if (unit2ProductionTime < 0)
            {
                //Transform spawnPoint = transform.Find("/spawnPoint").gameObject;
                spawnPointTwo = this.transform.Find("spawnPointTwo");
                Instantiate(unit2, spawnPointTwo.position, spawnPointTwo.rotation);
                unit2MinCost = unit2MinCost - 15;

                /*  unitySupplyCountTemp += unit2SupplyCount;
                  unitSupplyLoss = getCurrSupply.supplyCountManager;
                  Debug.Log("subtracted: " + unitySupplyCountTemp + " from " + unitSupplyLoss);*/

                GameObject building = GameObject.FindWithTag("building");
                building.GetComponent<buildUnits>().enabled = false;
                unit2ProductionTime = unit2ProductionReset;
                unit2InProduction = false;
            }
        }
    }

    void buildUnitOne()
    {

    }
}
