﻿using UnityEngine;
using System.Collections;

public class cameraVelocity : MonoBehaviour {
    public float propulsion = .1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("w"))
        {
            GetComponent<Rigidbody>().velocity = (propulsion * gameObject.transform.forward) + GetComponent<Rigidbody>().velocity;
        }

    }
}
