/*
 * Name: Ethan Herndon
 * Date: 12/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scavengerController : MonoBehaviour
{

    public GameObject GameManager;
 
    void Start()
    {
       
        GameManager.GetComponent<NomadClick>().enabled = false;
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
                if (hit.collider.gameObject.tag == "scavenger")
                {
                    Debug.Log("SCV ready to go sir!");
                    GameManager.GetComponent<NomadClick>().enabled = true;
                    return;
                }
                wordPos = hit.point;
            }
            else
            {
                wordPos = Camera.main.ScreenToWorldPoint(mousePos);
                GameManager.GetComponent<NomadClick>().enabled = false;
            }

        }



    }
}
