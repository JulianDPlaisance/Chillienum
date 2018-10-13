using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    public Camera cam;
    public GameObject particle;
    public GameObject player;
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
            RaycastHit2D hit = Physics2D.Raycast(transform.position, ray.origin);
            Debug.Log("Alpha");
            if (hit.collider != null)
            {
                switch (hit.collider.tag)
                {
                    case "Tree":
                        Debug.Log("TREEEEEE");
                        break;
                    case "Rock":
                        Debug.Log("CAPTAIN PLANET");
                        break;
                    default:
                        Debug.Log("Damn");
                        break;
                }
            }
        }
    }
}
