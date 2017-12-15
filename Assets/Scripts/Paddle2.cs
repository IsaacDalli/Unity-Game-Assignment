using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {
	
	private Rigidbody2D rb;
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.Mouse1)) {
			rb.velocity = new Vector2 (0f, 6f);
		} else if (Input.GetKey (KeyCode.Mouse0)) {
			rb.velocity = new Vector2 (0f, -6f);
		} else {
			rb.velocity = new Vector2 (0f, 0f);
		}
	}
}
