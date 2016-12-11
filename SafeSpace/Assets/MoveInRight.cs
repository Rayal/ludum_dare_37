using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInRight : MonoBehaviour {
	private bool isMoving;
	private Vector2 originPos = new Vector2 (-3, -3);
	private float destinationX = -0.5f;

	void Start () {
		isMoving = false;
	}

	void Update () {
		if (isMoving) {
			if (HasReachedDestination ())
				isMoving = false;
			else
				Move ();
		}
	}

	private bool HasReachedDestination () {
		bool hasReachedDestination = transform.position.x >= destinationX;

		return hasReachedDestination;
	}

	private void Move () {
		transform.Translate (Vector2.right * Time.deltaTime);
	}

	public void Go () {
		ResetPosition ();
		isMoving = true;
	}

	private void ResetPosition () {
		transform.position = originPos;
	}
}
