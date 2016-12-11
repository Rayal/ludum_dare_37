﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceController : MonoBehaviour {
	public int goodCount = 0;
	public int badCount = 0;
	public Text statsText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ResetCounts () {
		goodCount = 0;
		badCount = 0;
	}

	public void ChooseGood () {
		// FIXME: hack
		if (goodCount + badCount >= 5) {
			Application.Quit ();
		}
		goodCount++;
	}

	public void ChooseBad () {
		// FIXME: hack
		if (goodCount + badCount >= 5) {
			Application.Quit ();
		}
		badCount++;
	}

	public void PresentStats () {
		string goodChoicesPlural = MakeChoicesPlural (goodCount);
		string badChoicesPlural = MakeChoicesPlural (badCount);
		statsText.text = "You made " + goodCount + " good " + goodChoicesPlural + " and " + badCount + " bad " + badChoicesPlural;
	}

	private string MakeChoicesPlural (int count) {
		string phrase = count == 1 ? "choice" : "choices";

		return phrase;
	}
}
