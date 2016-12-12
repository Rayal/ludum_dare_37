using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public class DialogDatabase {
	public static Dictionary<string, DialogNode> nodes = new Dictionary<string, DialogNode>();

	public static void Build () {
		AddNode (new DialogNode ("moralDilemmaRoot", "This is a moral dilemma", new DialogEdge[] {
			new DialogEdge ("Choose good", "goodConsequence"),
			new DialogEdge ("Choose bad", "badConsequence")
		}, 0));
		AddNode (new DialogNode ("goodConsequence", "This is a good consequence", new DialogEdge[]{ }, 1));
		AddNode (new DialogNode ("badConsequence", "This is a bad consequence", new DialogEdge[]{ }, -1));
	}

	public static void AddNode (DialogNode node) {
		nodes [node.id] = node;
	}

	public static DialogNode GetNode (string id) {
		return nodes [id];
	}
}
