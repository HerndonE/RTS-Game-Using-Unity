/*
 * Name: Ethan Herndon
 * Date: 12/7/2020
 * Class: CST 426
 * Old script modified from my SRJC Game Dev Class
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NomadClick : MonoBehaviour
{

    public int smooth = 0; // Determines how quickly object moves towards position
    private Vector3 targetPosition;
    public int speed = 10;
    Plane playerPlane; //public Plane groundPlane;
    //public GameObject clickEffect;

    public float x;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            playerPlane = new Plane(Vector3.up, transform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance = 0.0f; //float  hitdist; // float rayDistance;

            // The best overloaded method match for `UnityEngine.Plane.Raycast(UnityEngine.Ray, out float)' 
            //has some invalid arguments

            if (playerPlane.Raycast(ray, out rayDistance))
            {
                targetPosition = ray.GetPoint(rayDistance);
               
                //targetPosition = ray.GetPoint(rayDistance);
                //var targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
                //transform.rotation = targetRotation;

            }
        }

        Vector3 dir = targetPosition - transform.position;
        float dist = dir.magnitude;
        float move = speed * Time.deltaTime;

        if (dist > move)
        {
            //transform.position += dir.normalized * move; //Rotares cube
            /*		
                  if (clickEffect != null)
                  {
                      Instantiate(clickEffect, targetPosition, Quaternion.identity);
                  }*/

        }
        else
        {
            transform.position = targetPosition;
        }

        transform.position += (targetPosition - transform.position).normalized * speed * Time.deltaTime;

    }

  
}