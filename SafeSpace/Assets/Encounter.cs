using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter {
	public string id;
	public string entityId;
	public string dialogNodeId;

	public Encounter (string id, string entityId, string dialogNodeId) {
		this.id = id;
		this.entityId = entityId;
		this.dialogNodeId = dialogNodeId;
	}
}
