using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAnimation : MonoBehaviour {
	public GameObject Character;
	public GameObject Baddie;

	class XAnimation {
		public Vector3 current= new Vector3();

		public Vector3 start  = new Vector3();
		public Vector3 finish = new Vector3();

		public float time = 0.0f;
		public float duration = 1.0f;

		public XAnimation(Vector3 start, Vector3 finish){
			this.start = start;
			this.finish = finish;
		}

		public void Reset(){
			this.time = 0.0f;
		}

		public void Update(float dt){
			time += dt;
			float p = time / duration;
			current = Vector3.Lerp (start, finish, p);
		}
	}

	XAnimation characterAnimation = new XAnimation(new Vector3(-12f, -2.8f, 0f), new Vector3(-3f, -2.8f, 0f));
	XAnimation baddieAnimation = new XAnimation(new Vector3(12f, -2.8f, 0f), new Vector3(3f, -2.8f, 0f));

	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		characterAnimation.Update (Time.deltaTime);
		Character.transform.position = characterAnimation.current;

		baddieAnimation.Update (Time.deltaTime);
		Baddie.transform.position = baddieAnimation.current;
	}

	public void Reset () {
		characterAnimation.Reset ();
		baddieAnimation.Reset ();
	}
}
