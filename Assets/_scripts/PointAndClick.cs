﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    public Camera cam;
    public GameObject particle;
    public GameObject player;
    public LayerMask mask;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(transform.position, ray.origin, Color.green);

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, ray.origin, 1000f, mask.value);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
                
                switch (hit.collider.tag)
                {
                    case "Tree":
                        hit.collider.GetComponent<Rigidbody2D>().transform.localScale *= 2;
                        break;
                    case "Rock":
                        hit.collider.GetComponent<Rigidbody2D>().mass /= 5;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}