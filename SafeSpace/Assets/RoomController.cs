using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour {
	public GameObject controllers;

	void Start () {
		//controllers = GameObject.Find ("Controllers");
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
