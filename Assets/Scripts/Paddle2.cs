using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {
	private float speed = 8f;
	private Rigidbody2D rb;
	public Rigidbody2D rb2;
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.Mouse1)) {
			rb.velocity = new Vector2 (0f, speed);
			rb2.velocity = new Vector2 (0f, speed);
		} else if (Input.GetKey (KeyCode.Mouse0)) {
			rb.velocity = new Vector2 (0f, -speed);
			rb2.velocity = new Vector2 (0f, -speed);
		} else {
			rb.velocity = new Vector2 (0f, 0f);
			rb2.velocity = new Vector2 (0f, 0f);
		}
	}
}
