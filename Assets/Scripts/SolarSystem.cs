using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour {

	public GameObject Sun;
	public GameObject Mercury;
	public GameObject Venus;
	public GameObject Earth;
	public GameObject Moon;
	public GameObject Mars;
	public GameObject Phobos;
	public GameObject Deimos;
	public GameObject Jupiter;
	public GameObject Saturn;
	public GameObject Uranus;
	public GameObject Neptune;
	public GameObject Pluto;


	// Use this for initialization
	void Start () {
		Instantiate (Sun);
		Instantiate (Mercury);
		Instantiate (Venus);
		Instantiate (Earth);
		Instantiate (Moon);
		Instantiate (Mars);
		Instantiate (Phobos);
		Instantiate (Deimos);
		Instantiate (Jupiter);
		Instantiate (Saturn);
		Instantiate (Uranus);
		Instantiate (Neptune);
		Instantiate (Pluto);
	}
}
