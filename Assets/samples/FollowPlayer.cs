using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject playr;
    Transform trans;
    Transform offset;
	// Use this for initialization
	void Start () {
        offset = this.transform;
        trans = playr.transform;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = (offset.position + playr.transform.position);
	}
}
