﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_portal : MonoBehaviour {

    public float rotSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + rotSpeed);

	}
}
