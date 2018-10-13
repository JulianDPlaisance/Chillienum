using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    public Camera cam;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, 90 * Vector2.right, Color.green);
        Debug.DrawRay(transform.position, Input.mousePosition, Color.blue, 0f, true);
        Debug.DrawLine(transform.position, 90 * Vector2.right, Color.red, 0f, true);
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("fire");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, 90 * Vector2.right);
            

            Debug.Log(hit.ToString());
            Debug.Log(hit.distance);

            if (hit.collider != null)
            {
                /*switch (hit.collider.tag)
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
                }*/
                if(hit.collider.tag != null)
                {
                    Debug.Log(hit.collider.tag);
                }
            }
        }
    }
}
