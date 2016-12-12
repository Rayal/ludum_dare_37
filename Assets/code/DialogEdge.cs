using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogEdge {
	public string description;
	public string destinationId;

	public DialogEdge (string description, string destinationId) {
		this.description = description;
		this.destinationId = destinationId;
	}
}
