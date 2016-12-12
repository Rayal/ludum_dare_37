using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class DialogEdge {
	public string description;
	public string destinationId;

	public DialogEdge (string description, string destinationId) {
		this.description = description;
		this.destinationId = destinationId;
	}
}
