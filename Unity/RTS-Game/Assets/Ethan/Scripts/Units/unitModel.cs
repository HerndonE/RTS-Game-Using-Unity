/*
 * Name: Ethan Herndon
 * Date: 12/2/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitModel : MonoBehaviour
{
    public static int unitSupplyCount;
    public int unitSupplyCost;

    // Start is called before the first frame update
    void Start()
    {

        unitSupplyCount = unitSupplyCount + unitSupplyCost;
        Debug.Log("Unit Supply Count:" + unitSupplyCount);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnDestroy()
    {
        unitSupplyCount -= 10;
        Debug.Log("Unit Supply Count:" + unitSupplyCount);
    }
}
