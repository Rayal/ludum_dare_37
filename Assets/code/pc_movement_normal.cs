﻿using UnityEngine;
using System.Collections;

public class pc_movement_normal : MonoBehaviour {
	public Vector3 start_position;
	public bool use_def_pos = true;
	Vector3 mouse_pos;
	// Use this for initialization
	void Start () {
		if (!use_def_pos)
			transform.position = start_position;
		mouse_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (1)) {
			mouse_pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mouse_pos.y = transform.position.y;
			mouse_pos.z = transform.position.z;
		}
		float delta = mouse_pos.x - transform.position.x;
		if (delta != 0) {
			gameObject.GetComponent<SpriteRenderer> ().flipX = (delta < 0);
			transform.Translate (Time.deltaTime * delta, 0, 0);
		}

		//TODO: Action for mouse button 0
	}
}
