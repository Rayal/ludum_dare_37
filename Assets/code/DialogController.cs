using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {
	public Text text;
	public GameObject game;
	public Button[] choices;

	void Start () {
		DisableChoices ();
	}
	
	void Update () {
	}

	public void RenderNode (string id) {
		// TODO: move text with camera?

		DisableChoices ();

		DialogNode node = DialogDatabase.GetNode(id);

		game.SendMessage ("ApplyConsequence", node.consequence);
		text.text = node.text;
		int idxEdge = 0;
		foreach (DialogEdge edge in node.edges) {
			Button choice = choices [idxEdge];
			RenderChoice (choice, edge);
			idxEdge++;
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
		btn.onClick.AddListener (() => {
			RenderNode (edge.destinationId);
		});
	}
}
