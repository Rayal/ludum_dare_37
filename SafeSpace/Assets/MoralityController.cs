using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoralityController : MonoBehaviour {
	public int morality = 0;
	
	void Start () {
	}

	void Update () {
	}

	public void ApplyConsequence (int consequence) {
		morality += consequence;
	}
}
