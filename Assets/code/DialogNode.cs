using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNode {
	public string id;
	public string text;
	public DialogEdge[] edges;
	public int consequence;

	public DialogNode (string id, string text, DialogEdge[] edges, int consequence) {
		this.id = id;
		this.text = text;
		this.edges = edges;
		this.consequence = consequence;
	}
}
