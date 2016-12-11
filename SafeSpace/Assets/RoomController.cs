using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour {
	private GameObject character;
	private GameObject baddie;
	private GameObject controllers;

	void Start () {
		character = GameObject.Find ("Character");
		baddie = GameObject.Find ("Baddie");
		controllers = GameObject.Find ("Controllers");
	}

	void Update () {
	}

	public void PresentCurrentRoom () {
		controllers.SendMessage ("Reset");
		DisplayDialog ();
	}

	private void DisplayDialog () {
		// TODO
	}
}
