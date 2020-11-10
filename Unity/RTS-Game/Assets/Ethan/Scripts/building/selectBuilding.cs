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
