using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public CharacterManager characterManager;

	Vector3 startPos, endPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ManageInput ();
	}

	void ManageInput() {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100)) {
				if (hit.collider.gameObject.CompareTag ("Character")) {
					characterManager.Select (hit.collider.gameObject);
				}
			}
			startPos = Input.mousePosition;
		}

		if (Input.GetMouseButton (0)) {
			endPos = Input.mousePosition;

		}

		if (Input.GetMouseButtonUp (0)) {
			endPos = Input.mousePosition;


		}

		if (Input.GetMouseButtonDown (1)) {
			//Send commands
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100)) {
				Vector3 targetPos = hit.point;
				Debug.Log (hit.point);
				characterManager.SendMoveCommand (targetPos);
			}

			//characterManager.SendCommand(Camera.main.ScreenToWorldPoint(Input.mousePosition));
			//Debug.Log ("Target pos: " + Camera.main.ScreenToWorldPoint (Input.mousePosition));
		}
	}

}

