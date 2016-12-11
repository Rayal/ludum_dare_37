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
			float y = choices [idxEdge].transform.position.y;
			choices [idxEdge].transform.position = new Vector2 (231.5f, y);
			choices [idxEdge].GetComponentInChildren<Text> ().text = edge.description;
			idxEdge++;
		}
	}

	private void DisableChoices () {
		foreach (Button choice in choices) {
			float y = choice.transform.position.y;
			choice.transform.position = new Vector2 (10000, y);
		}
	}
}
