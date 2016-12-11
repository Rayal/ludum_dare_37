using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {
	public Text text;

	void Start () {
	}
	
	void Update () {
	}

	public void RenderNode(string id) {
		// TODO: move text with camera?
		DialogNode node = DialogDatabase.GetNode(id);

		text.text = node.text;
	}
}
