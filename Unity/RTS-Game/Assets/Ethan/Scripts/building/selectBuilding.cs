/*
 * Name: Ethan Herndon
 * Date: 11/16/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectBuilding : MonoBehaviour
{
   
    void Start()
    {
 
    }

    void Update()
    {

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wordPos;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000f))
            {
                if (hit.collider.gameObject.tag == "building")
                {
                    Debug.Log("Now what!?");
                    //TODO

                    GameObject varGameObject = GameObject.FindWithTag("building");
                    varGameObject.GetComponent<buildUnits>().enabled = true;

                    return;
                }
                wordPos = hit.point;
            }
            else
            {
                wordPos = Camera.main.ScreenToWorldPoint(mousePos);
            }
 
        }

    }

}
