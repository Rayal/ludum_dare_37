using UnityEngine;
using System.Collections;

public class pc_movement_normal : MonoBehaviour {
	public Vector3 startposition;
	Vector3 mouse_pos = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start () {
		transform.position = startposition;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (1)) {
			mouse_pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mouse_pos.y = transform.position.y;
			mouse_pos.z = transform.position.z;
		}
		float delta = mouse_pos.x - transform.position.x;
		if (delta != 0) {
			transform.Translate (Time.deltaTime * delta, 0, 0);
		}

		//TODO: Action for mouse button 1
	}
}
