using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject room;
	public GameObject dialog;
	public Text statsText;
	public int morality = 0;
	private int roomIdx = 0;
	private int roomsCount = 5;

	void Start () {
		DialogDatabase.Build ();
		dialog.SendMessage ("RenderNode", "moralDilemmaRoot");
	}

	void Update () {
	}

	public void ApplyConsequence (int dMorality) {
		morality += dMorality;
	}

	public void Advance () {
		roomIdx++;
		if (roomIdx < roomsCount)
			room.SendMessage ("PresentCurrentRoom");
		else
			PresentStats ();
	}

	private void PresentStats () {
		statsText.text = "You finished with a net morality of " + morality;
	}
}
