/*
 * Name: Ethan Herndon
 * Date: 11/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildSupply : MonoBehaviour
{
 
    public GameObject thePrefab;
    public static int minCost;

    public AudioSource beepboop;
    public AudioSource badbeepboop;

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
                if (hit.collider.gameObject.tag == "supply")
                {
                    badbeepboop.Play();
                    Debug.Log("cannot comply!");
                    return;
                }
                if (hit.collider.gameObject.tag == "building")
                {
                    badbeepboop.Play();
                    Debug.Log("cannot comply!");
                    return;
                }

                if (hit.collider.gameObject.tag == "mineral")
                {
                    badbeepboop.Play();
                    Debug.Log("cannot comply!");
                    return;
                }

                if (hit.collider.gameObject.tag == "extractor")
                {
                    badbeepboop.Play();
                    Debug.Log("cannot comply!");
                    return;
                }

                wordPos = hit.point;
            }
            else
            {
                wordPos = Camera.main.ScreenToWorldPoint(mousePos);
            }
            beepboop.Play();
            Instantiate(thePrefab, wordPos + Vector3.up * 2f, Quaternion.identity);//use to be 1f
            minCost = minCost - 10;
            //supplyBuildings = GameObject.FindGameObjectsWithTag("supply");
        }

      

    }

}
