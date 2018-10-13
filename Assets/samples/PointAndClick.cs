using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    public Camera cam;
    public GameObject particle;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, 900 * Vector2.right, Color.green);
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("fire");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, 900 * Vector2.right);
            //RaycastHit2D hit = Physics2D.Raycast(transform.position, Input.mousePosition, 10000f);
            

            Debug.Log(hit.ToString());


            if (hit.collider != null)
            {
                Instantiate(particle, new Vector3(transform.position.x + hit.distance / 2, transform.position.y + hit.distance / 2, 0), new Quaternion());
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
