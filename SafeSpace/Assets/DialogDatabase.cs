using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public class DialogDatabase {
	public static Dictionary<string, DialogNode> nodes = new Dictionary<string, DialogNode>();

	public static void Build () {
		AddNode(new DialogNode ("red1-1", "Oh, I would love to!\n\t\tThe two of you go on a date and grow very fond of each other.", new DialogEdge[]{ }, 2));
		AddNode(new DialogNode ("red1-2", "Hi, White! I was just thinking about what Professor Pickman said.\n\t\tDo you also think that the practice of dactylomancy in recent media covering has been increasingly skewed.\n\t\tYou spend some time chatting with Red and you grow closer.", new DialogEdge[]{ }, 1));
		AddNode(new DialogNode ("red1-3", "What's the matter, White?\n\t\tOh well, it's time for class anyway.\n\t\tYou awkwardly stumble away, almost losing your footing.", new DialogEdge[]{ }, 0));
		var red10Edges = new DialogEdge[] {
			new DialogEdge ("Ask Red on a romantic date.", "Red1-1"),
			new DialogEdge ("Hi Red. How are you today?", "Red1-2"),
			new DialogEdge ("Stay awkwardly silent.", "Red1-3"),
		};
		AddNode(new DialogNode ("red1-0", "It's Red.... She has been on your mind lately. \n\t\tHer enticing crimson skin, her majestic nose...\n\t\tShe was a sight for sore eyes, for sure.", red10Edges, 0));
	}

	public static void AddNode (DialogNode node) {
		nodes [node.id] = node;
	}

	public static DialogNode GetNode (string id) {
		return nodes [id];
	}
}
