using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialObject : MonoBehaviour {

	public GameObject parent;
	public Vector3 rotation = new Vector3(0,1,0);
	public Vector3 orbitAxis = new Vector3(0, -1, 0);
	public float orbitalSpeed = 1;
	public float distance;
	public float rotationSpeed;
	public string parentTag = "Sun";
	public float size;

	private Vector3 relativeDistance ;

	// Use this for initialization
	void Start () {
		parent = GameObject.FindGameObjectWithTag (parentTag);

		transform.localScale *= size;

		transform.position = parent.transform.position;
		transform.position += new Vector3(0, 0, 1) * distance*1.5f;
		Debug.Log ("Position: " + transform.position);

		relativeDistance = transform.position - parent.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotation * rotationSpeed);

		transform.position = parent.transform.position + relativeDistance;
		transform.RotateAround (parent.transform.position, orbitAxis, orbitalSpeed);
	}

	void LateUpdate() {
		relativeDistance = transform.position - parent.transform.position;
	}
}
