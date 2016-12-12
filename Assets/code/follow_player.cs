using UnityEngine;
using System.Collections;

public class follow_player : MonoBehaviour {
	public GameObject pc_object;
	public float world_length;
	public bool camera_unlimited = true;

	private float camera_limit;
	// Use this for initialization
	void Start () {
		float len = Camera.main.orthographicSize * Camera.main.aspect * 2;
		Debug.Log (len);
		camera_limit = (world_length - len) / 2;
		follow ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		follow ();
	}

	void follow () {
		float offset = pc_object.transform.position.x - transform.position.x;
		if ((offset != 0 && pc_object.transform.position.x > -camera_limit && pc_object.transform.position.x < camera_limit) ||
			(offset != 0 && camera_unlimited)){
			transform.Translate (offset, 0, 0);
		}
		else if (pc_object.transform.position.x <= -camera_limit) {
			transform.position = new Vector3(-camera_limit, transform.position.y, transform.position.z);
		}
		else if (pc_object.transform.position.x >= camera_limit) {
			transform.position = new Vector3(camera_limit, transform.position.y, transform.position.z);
		}
	}
}
