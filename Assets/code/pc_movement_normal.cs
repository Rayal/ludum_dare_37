using UnityEngine;
using System.Collections;

public class pc_movement_normal : MonoBehaviour {
	public Vector3 start_position;
	public bool use_def_pos = true;

	float target_pos;
	Animator anim;
	int delta = 0;
	//bool move_to_point = false;
	// Use this for initialization
	void Start () {
		if (!use_def_pos)
			transform.position = start_position;
		target_pos = transform.position.x;

		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow))
			target_pos = transform.position.x;
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			target_pos = transform.position.x - 2;
			if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift))
				target_pos -= 6;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			target_pos = transform.position.x + 2;
			if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift))
				target_pos += 6;
		} else if (Input.GetMouseButton (1)) {
			target_pos = Camera.main.ScreenToWorldPoint (Input.mousePosition).x;
		}

		delta = Mathf.FloorToInt (target_pos - transform.position.x);

		transform.Translate (Time.deltaTime * delta, 0, 0);
		
		anim.SetFloat("speed", Mathf.Abs (delta));
		if (delta < 0)
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		else if (delta > 0)
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;

		stop_punch ();
		if (Input.GetKeyDown (KeyCode.Space))
			punch ();
	}

	void punch() {
		anim.SetBool ("attack", true);
	}

	void stop_punch(){
		anim.SetBool ("attack", false);
		if (Input.GetMouseButton (0) || Input.GetMouseButton (1)) {
			mouse_pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mouse_pos.y = transform.position.y;
			mouse_pos.z = transform.position.z;
		}
		int delta = Mathf.FloorToInt(mouse_pos.x - transform.position.x);
		
		anim.SetFloat("speed", Mathf.Abs (delta));
		if (delta != 0) {
			gameObject.GetComponent<SpriteRenderer> ().flipX = (delta < 0);
			transform.Translate (Time.deltaTime * delta, 0, 0);
		}
	}
}
