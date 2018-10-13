using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {
    public Camera cam;
    public GameObject particle;
    public Ray ray;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Input.mousePosition);
            
            if(hit.collider != null)
            {
                Debug.Log(hit.collider.ToString());
            }
        }
	}
}
