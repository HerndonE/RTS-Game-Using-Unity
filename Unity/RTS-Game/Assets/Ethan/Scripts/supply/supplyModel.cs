﻿/*
 * Name: Ethan Herndon
 * Date: 12/2/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supplyModel : MonoBehaviour
{
    public static int supplyCount;
   
    // Start is called before the first frame update
    void Start()
    {
        
        supplyCount = supplyCount + 10;
        Debug.Log("Supply Count:" + supplyCount);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnDestroy()
    {
        supplyCount -= 10;
        Debug.Log("Supply Count:" + supplyCount);
    }
}
