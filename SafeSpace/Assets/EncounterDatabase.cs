using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterDatabase {
	public static Dictionary<string, Encounter> encounters = new Dictionary<string, Encounter>();

	public static void Build() {
		Encounter hornyBeast = new Encounter ("red1-0", "red1-0", "red1-0");
		AddEncounter (hornyBeast);
	}

	public static void AddEncounter (Encounter encounter) {
		encounters [encounter.id] = encounter;
	}

	public static Encounter GetEncounter (string id) {
		return encounters [id];
	}
}
