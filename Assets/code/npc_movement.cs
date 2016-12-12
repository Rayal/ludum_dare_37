using UnityEngine;
using System.Collections;

public class npc_movement_normal : MonoBehaviour {
	public Vector3 start_position;
	public bool use_def_pos = true;
	public float target_pos;
	public bool punch = false;

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
		delta = Mathf.FloorToInt (target_pos - transform.position.x);

		transform.Translate (Time.deltaTime * delta, 0, 0);

		anim.SetFloat("speed", Mathf.Abs (delta));
		if (delta < 0)
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		else if (delta > 0)
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;

		stop_punch ();
		anim.SetBool ("attack", punch);
	}

	void stop_punch(){
		punch = true;
		anim.SetBool ("attack", false);
	}
}
