using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	private GameObject controllers;
	private int roomIdx = 0;
	private int roomsCount = 5;

	void Start () {
		controllers = GameObject.Find ("Controllers");

		controllers.SendMessage ("PresentCurrentRoom");
	}

	void Update () {
	}

	public void Advance () {
		roomIdx++;
		if (roomIdx < roomsCount)
			controllers.SendMessage ("PresentCurrentRoom");
		else
			controllers.SendMessage ("PresentStats");
	}
}
