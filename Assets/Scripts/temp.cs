using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour {

	public GameObject earth;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				for (int k = 0; k < 10; k++) {
					Vector3 pos = new Vector3 (1*i, 1*k, 1*j);
					Quaternion rot = new Quaternion ();
					Instantiate (earth, pos, rot);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
