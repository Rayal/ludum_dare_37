﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {
	public Text text;
	public GameObject morality;
	//public GameObject animation;
	public Button[] choices;
	public GameObject pc;

	void Start () {
		DialogDatabase.Build ();
		EncounterDatabase.Build ();
		DisableChoices ();
	}
	
	void Update () {
	}

	public void StartDialog (string encounterId) {
		Encounter encounter = EncounterDatabase.GetEncounter (encounterId);
		// TODO: Get baddie gameObject based on encounter entityId.
		// TODO: set animation baddie object.
		//animation.SendMessage ("Reset");
		RenderNode (encounter.dialogNodeId);
	}

	public void RenderNode (string id) {
		DisableChoices ();

		DialogNode node = DialogDatabase.GetNode(id);

		morality.SendMessage ("ApplyConsequence", node.consequence);
		text.text = node.text;

		if (node.edges.Length == 0) {
			RenderContinue ();
		} else {
			int idxEdge = 0;
			foreach (DialogEdge edge in node.edges) {
				Button choice = choices [idxEdge];
				RenderChoice (choice, edge);
				idxEdge++;
			}
		}
	}

	private void DisableChoices () {
		foreach (Button choice in choices) {
			choice.gameObject.SetActive (false);
		}
	}

	private void RenderChoice(Button btn, DialogEdge edge) {
		btn.gameObject.SetActive (true);
		btn.GetComponentInChildren<Text> ().text = edge.description;
		btn.onClick.RemoveAllListeners();
		btn.onClick.AddListener (() => {
			RenderNode (edge.destinationId);
		});
	}

	private void RenderContinue () {
		Button btn = choices [0];
		btn.gameObject.SetActive (true);
		btn.GetComponentInChildren<Text> ().text = "Continue";
		btn.onClick.RemoveAllListeners();
		btn.onClick.AddListener (() => {
			Camera.main.GetComponent<follow_player> ().follow_pc = true;
			pc.SendMessage("SetForceMotion", false);
			Hide();
		});
	}

	public void Hide () {
		text.text = "";
		DisableChoices ();
	}
}
