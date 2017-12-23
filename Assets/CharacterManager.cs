using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

	public GameObject[] characters;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select(GameObject selectedCharacter) {
		for (int i = 0; i < characters.Length; i++) {
			characters [i].GetComponent<PlayerController> ().Select (false);
		}

		selectedCharacter.GetComponent<PlayerController> ().Select (true);
	}

	public void SendMoveCommand(Vector3 position) {
		for (int i = 0; i < characters.Length; i++) {
			if (characters [i].GetComponent<PlayerController> ().selected) {
				characters [i].transform.position = new Vector3 (position.x, 0, position.z);
			}
		}
	}
}
