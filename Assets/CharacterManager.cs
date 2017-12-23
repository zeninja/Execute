using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

	public float speed = 10f;
	public Vector3 movePos;
	bool moving;
	public GameObject[] characters;
	GameObject currentMovingObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			currentMovingObject.transform.position = Vector3.MoveTowards (currentMovingObject.transform.position, movePos, speed * Time.deltaTime);
		}
	}


	public void Select(GameObject selectedCharacter) {
		for (int i = 0; i < characters.Length; i++) {
			characters [i].GetComponent<PlayerController> ().Select (false);
		}

		selectedCharacter.GetComponent<PlayerController> ().Select (true);
	}

	public void SendMoveCommand(Vector3 position) {
		movePos = position;
		for (int i = 0; i < characters.Length; i++) {
			if (characters [i].GetComponent<PlayerController> ().selected) {
				moving = true;
				currentMovingObject = characters [i];
			}
		}
	}
}
