using UnityEngine;
using System.Collections;

public class observable_object : MonoBehaviour {
	public Vector3 startposition;
	public bool use_def_pos = true;
	public GameObject target;

	// Use this for initialization
	void Start () {
		if (use_def_pos)
			transform.position = startposition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp()
	{
		Debug.Log ("Mouse clicked me.");
	}

}
