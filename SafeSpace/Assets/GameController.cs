using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject room;
	public GameObject choice;
	private int roomIdx = 0;
	private int roomsCount = 5;

	void Start () {
		room.SendMessage ("PresentCurrentRoom");
	}

	void Update () {
	}

	public void Advance () {
		roomIdx++;
		if (roomIdx < roomsCount)
			room.SendMessage ("PresentCurrentRoom");
		else
			choice.SendMessage ("PresentStats");
	}
}
