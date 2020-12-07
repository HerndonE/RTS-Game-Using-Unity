using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceCollection : MonoBehaviour
{

    public float resourceGatheringTime = 5.0f;
    private bool gatheringInProduction = false;
    public Transform target;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.GetComponent<NomadClick>().enabled == false) {
            Collider m_Collider = GetComponent<Collider>();
             m_Collider.enabled = !m_Collider.enabled;
            resourceGatheringTime -= Time.deltaTime;
            Debug.Log("Time Left:" + Mathf.Round(resourceGatheringTime));
            if (resourceGatheringTime < 0)
            {
                Debug.Log("Resource gathered");
                this.GetComponent<NomadClick>().enabled = true;
                gatheringInProduction = false;
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
                //Todo Gather Resources and GoTo building and repeat
            }
        }


    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "mineral")
        {
            Debug.Log("I am at minerals");
            gatheringInProduction = true;
            if (gatheringInProduction)
            {
                this.GetComponent<NomadClick>().enabled = false;
            }
        }

    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "mineral")
        {
            Debug.Log("I left minerals");
            this.GetComponent<NomadClick>().enabled = true;

        }

    }

}
