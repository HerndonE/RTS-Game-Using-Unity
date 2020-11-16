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
    public Transform spawnPoint;
    public float unit1ProductionTime = 5.0f;
    public float unit1ProductionReset = 5.0f;
    public float unit2ProductionTime = 10.0f;
    public float unit2ProductionReset = 10.0f;
    private bool unit1InProduction = false;
    private bool unit2InProduction = false;
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
                spawnPoint = this.transform.Find("spawnPoint");
                Instantiate(unit1, spawnPoint.position, spawnPoint.rotation);

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
                spawnPoint = this.transform.Find("spawnPoint");
                Instantiate(unit2, spawnPoint.position, spawnPoint.rotation);

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
