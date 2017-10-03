﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {
	public Vector3 rotation = new Vector3(0,1,0);
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(rotation * rotationSpeed);
	}
}