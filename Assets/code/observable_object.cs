using UnityEngine;
using System.Collections;

public class observable_object : MonoBehaviour {
	public Vector3 startposition;

	public GameObject target;

	// Use this for initialization
	void Start () {
		transform.position = startposition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp()
	{
		Debug.Log ("Mouse clicked me.");
		var instance = Instantiate (target); // Resources.Load ("SPR_ME")
		//instance = instance;
	}

}
