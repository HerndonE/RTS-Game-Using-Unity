using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//gratuitous comment

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -0.5F, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
