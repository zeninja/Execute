using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public bool selected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select(bool value) {
		selected = value;
		if (selected) {
			GetComponent<MeshRenderer> ().material.color = Color.red;
		} else {
			GetComponent<MeshRenderer> ().material.color = Color.white;
		}
	}
}
