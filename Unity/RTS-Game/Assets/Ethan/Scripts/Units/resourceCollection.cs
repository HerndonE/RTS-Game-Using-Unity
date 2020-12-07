using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceCollection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "mineral")
        {
            Debug.Log("I am at minerals");
            this.GetComponent<NomadClick>().enabled = false;
            //Debug.Log("Target Position: " + targetPosition);

        }
        else
        {
            this.GetComponent<NomadClick>().enabled = true;
        }
    }

}
