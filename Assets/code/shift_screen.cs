using UnityEngine;
using System.Collections;

public class shift_screen : MonoBehaviour {
	public Vector3 screen_size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Camera.main.transform.Translate (screen_size);
	}
}
