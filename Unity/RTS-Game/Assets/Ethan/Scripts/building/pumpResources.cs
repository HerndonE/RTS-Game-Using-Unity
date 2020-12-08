/*
 * Name: Ethan Herndon
 * Date: 12/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pumpResources : MonoBehaviour
{

    public static int resourceCount;
    public Transform mineral;


    void Start()
    {
        StartCoroutine(onCoroutine());
    }

    IEnumerator onCoroutine()
    {
        while (true)
        {
            Debug.Log("OnCoroutine: " + (int)Time.time);
            resourceCount = resourceCount + 5;
            yield return new WaitForSeconds(10f);
        }
    }


    void OnDestroy()
    {
        Instantiate(mineral, transform.position, Quaternion.identity);
    }

}
