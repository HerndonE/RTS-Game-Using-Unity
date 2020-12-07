using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    public float delay;
    // Use this for initialization
    void Start()
    {
        GameObject.Destroy(gameObject, delay);
    }

}
